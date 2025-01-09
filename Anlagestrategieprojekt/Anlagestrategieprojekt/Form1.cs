using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Anlagestrategieprojekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            l_sS_1.Visible = false;
            l_sS_2.Visible = false;
            l_sS_3.Visible = false;
        }

        // Quelle: https://dotnet-snippets.de/snippet/varianz-und-mittelwert/12054
        public double Mittelwert(double[] array)
        {
            double summe = 0;
            double ergebnis = 0;
            int i;
            for (i = 0; i < array.Length; i++)
            {
                summe += array[i];
            }
            ergebnis = summe / i;
            return ergebnis;

        }

        // Quelle: https://dotnet-snippets.de/snippet/varianz-und-mittelwert/12054
        public double Varianz(double[] array)
        {
            double mittelwert = Mittelwert(array);
            double summe = 0;
            double ergebnis = 0;
            int i;
            for (i = 0; i < array.Length; i++)
            {
                summe += Math.Pow(array[i], 2);
            }
            double mittelwertDerQuadrate = summe / i;
            ergebnis = mittelwertDerQuadrate - Math.Pow(mittelwert, 2);
            return ergebnis;

        }

        // Quelle: https://stackoverflow.com/questions/17447817/correlation-of-two-arrays-in-c-sharp
        public double BerechneKorrelation(double[] values1, double[] values2)
        {
            if (values1.Length != values2.Length)
                throw new ArgumentException("Um die Korrelation zu berechnen, braucht man gleichlange Elemente");

            var avg1 = values1.Average();
            var avg2 = values2.Average();

            var sum1 = values1.Zip(values2, (x1, y1) => (x1 - avg1) * (y1 - avg2)).Sum();

            var sumSqr1 = values1.Sum(x => Math.Pow((x - avg1), 2.0));
            var sumSqr2 = values2.Sum(y => Math.Pow((y - avg2), 2.0));

            var result = sum1 / Math.Sqrt(sumSqr1 * sumSqr2);

            return result;
        }

        // Quelle: https://stackoverflow.com/questions/36637882/epplus-read-excel-table
        static List<List<double>> LeseExcelDatei(string filePath)
        {
            var daten = new List<List<double>>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];

                var rows = worksheet.Dimension.Rows;
                var cols = worksheet.Dimension.Columns;

                for (int col = 1; col <= cols; col++)
                {
                    var datensatz = new List<double>();
                    for (int row = 1; row <= rows; row++)
                    {
                        var cellValue = worksheet.Cells[row, col].Text;

                        if (double.TryParse(cellValue, out double numericValue))
                        {
                            datensatz.Add(numericValue);
                        }
                        else
                        {
                            datensatz.Add(0);
                        }
                    }
                    daten.Add(datensatz);
                }
            }

            return daten;
        }

        private bool PruefeEingabeInt(string Eingabe)
        {
            return int.TryParse(Eingabe, out int Resultat);
        }

        static double BerechneDurchschnitt(double[] renditen)
        {
            double summe = 0;
            foreach (var rendite in renditen)
            {
                summe += rendite;
            }
            return summe / renditen.Length;
        }

        static double BerechneZukuenftigesKapital(int kapital, double durchschnittlicheRendite, double jahre)
        {
            return kapital * Math.Pow(1 + durchschnittlicheRendite, jahre);
        }

        static double BerechneZukuenftigesKapitalMitTagen(int kapital, double durchschnittlicheRendite, double tage)
        {
            return kapital * Math.Pow(1 + (Math.Pow(1 + durchschnittlicheRendite, 1.0 / 365) - 1), tage);
        }

        static double BerechneJahreUmZielKapitalZuErreichen(double aktuellesKapital, double zukuenftigesKapital, double rendite)
        {
            return Math.Log(zukuenftigesKapital / aktuellesKapital) / Math.Log(1 + rendite);
        }

        // Berechnet den Sicherheitsfaktor einer Anlagestrategie.
        // Ein höherer Wert des Sicherheitsfaktors bedeutet mehr Sicherheit.
        // Die Formel berücksichtigt:
        // 1. Varianz: Kleineres Risiko (niedrigere Varianz) erhöht den Sicherheitsfaktor. 
        //    +1 zur Varianz, um Division durch 0 zu vermeiden.
        // 2. Korrelation: Je näher die Korrelation an 1 (maximale Ähnlichkeit) ist, desto höher ist das Risiko.
        //    Die Korrelation wird durch (Korrelation - 1) transformiert und quadriert, um Risiken unabhängig von Vorzeichen zu bewerten.
        //    Das Resultat wird halbiert, um den Einfluss der Korrelation zu gewichten, da eine niedrige Korrelation zwar Diversifikation signalisiert, aber allein keine Garantie für Sicherheit bietet.
        static double BerechneSicherheitsfaktor(double Varianz, double Korrelation)
        {
            return (1 / (Varianz + 1)) + (Math.Pow(Korrelation - 1, 2) / 2);
        }

        static double BerechneGesamtwertung(double Varianz, double Korrelation, int tageBisZiel)
        {
            return (BerechneSicherheitsfaktor(Varianz, Korrelation) / tageBisZiel) * 100;
        }

        private void b_berechnen_Click(object sender, EventArgs e)
        {
            l_sS_1.Visible = false;
            l_sS_2.Visible = false;
            l_sS_3.Visible = false;

            int anfangskapital;
            int vermoegensziel;
            if (PruefeEingabeInt(tb_anfangskapital.Text) && PruefeEingabeInt(tb_vermoegensziel.Text))
            {
                anfangskapital = int.Parse(tb_anfangskapital.Text);
                vermoegensziel = int.Parse(tb_vermoegensziel.Text);
                l_ausgabe.Text = "";
            }
            else
            {
                l_ausgabe.Text = "Fehlerhafte Eingabe. Nur Ganzzahlen!";
                return;
            }

            if (anfangskapital >= vermoegensziel)
            {
                l_ausgabe.Text = "Vermögensziel schon erreicht!";
                return;
            }

            TimeSpan tage = dtp_zieldatum.Value - DateTime.Now;
            if (dtp_zieldatum.Value < DateTime.Now)
            {
                l_ausgabe.Text = "Zieldatum kann nicht in der Vergangenheit liegen!";
                return;
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string PfadAktien = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Anlagen_Aktien.xlsx");
            string PfadImmobilien = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Anlagen_Immobilien.xlsx");

            var datenAktien = LeseExcelDatei(PfadAktien);
            var datenImmobilien = LeseExcelDatei(PfadImmobilien);

            // Aktien
            double durchschnittsRenditeAktien = (BerechneDurchschnitt(datenAktien.ToArray()[0].ToArray()) + BerechneDurchschnitt(datenAktien.ToArray()[1].ToArray())) / 2;
            var datumZielErreicht = DateTime.Now.AddDays((int)(BerechneJahreUmZielKapitalZuErreichen(anfangskapital, vermoegensziel, durchschnittsRenditeAktien) * 365));
            double durchschnittsVarianzAktien = (Varianz(datenAktien.ToArray()[0].ToArray()) + Varianz(datenAktien.ToArray()[1].ToArray())) / 2;
            double durchschnittsKorrelationAktien = BerechneKorrelation(datenAktien.ToArray()[0].ToArray(), datenAktien.ToArray()[1].ToArray());
            double GesamtwertungAktien = Math.Round(BerechneGesamtwertung(durchschnittsVarianzAktien, durchschnittsKorrelationAktien, (datumZielErreicht - DateTime.Now).Days), 3);

            l_vK_1.Text = "Verteilung Kapital: Aktie A 50%, Aktie B 50%";
            l_kW_1.Text = "Erwartetes Kapital bei Wunschdatum: " + Math.Round(BerechneZukuenftigesKapitalMitTagen(anfangskapital, durchschnittsRenditeAktien, tage.Days)).ToString() + " CHF";
            l_dV_1.Text = "Datum bei Erreichen des Vermögensziels: " + DateOnly.FromDateTime(datumZielErreicht);
            l_jR_1.Text = "Erwartete jährliche Rendite: " + Math.Round(durchschnittsRenditeAktien, 2);
            l_v_1.Text = "Varianz: " + Math.Round(durchschnittsVarianzAktien, 2);
            l_k_1.Text = "Korrelation: " + Math.Round(durchschnittsKorrelationAktien, 2);
            l_gb_1.Text = "Gesamtbewertung: " + GesamtwertungAktien;

            // Immobilien und Aktien
            double durchschnittsRenditeImmobilien = (BerechneDurchschnitt(datenImmobilien.ToArray()[0].ToArray()) + BerechneDurchschnitt(datenImmobilien.ToArray()[1].ToArray())) / 2;
            double durchschnittsRendite2 = (durchschnittsRenditeAktien + durchschnittsRenditeImmobilien) / 2;
            var datumZielErreicht2 = DateTime.Now.AddDays((int)(BerechneJahreUmZielKapitalZuErreichen(anfangskapital, vermoegensziel, durchschnittsRendite2) * 365));
            double durchschnittsVarianzImmobilien = (Varianz(datenImmobilien.ToArray()[0].ToArray()) + Varianz(datenImmobilien.ToArray()[1].ToArray())) / 2;
            double durchschnittsVarianz2 = (durchschnittsVarianzAktien + durchschnittsVarianzImmobilien) / 2;
            double durchschnittsKorrelationImmobilien = BerechneKorrelation(datenImmobilien.ToArray()[0].ToArray(), datenImmobilien.ToArray()[1].ToArray());
            double durchschnittsKorrelation2 = (durchschnittsKorrelationAktien + durchschnittsKorrelationImmobilien) / 2;
            double Gesamtwertung2 = Math.Round(BerechneGesamtwertung(durchschnittsVarianz2, durchschnittsKorrelation2, (datumZielErreicht2 - DateTime.Now).Days), 3);

            l_vK_2.Text = "Verteilung Kapital: Aktien 50%, Immobilien 50%";
            l_kW_2.Text = "Erwartetes Kapital bei Wunschdatum: " + Math.Round(BerechneZukuenftigesKapitalMitTagen(anfangskapital, durchschnittsRendite2, tage.Days)).ToString() + " CHF";
            l_dV_2.Text = "Datum bei Erreichen des Vermögensziels: " + DateOnly.FromDateTime(datumZielErreicht2);
            l_jR_2.Text = "Erwartete jährliche Rendite: " + Math.Round(durchschnittsRendite2, 2);
            l_v_2.Text = "Varianz: " + Math.Round(durchschnittsVarianz2, 2);
            l_k_2.Text = "Korrelation: " + Math.Round(durchschnittsKorrelation2, 2);
            l_gb_2.Text = "Gesamtbewertung: " + Gesamtwertung2;

            // Immobilien und Obligationen
            double obligationsZins;

            if (double.TryParse(tb_ObligationsZins.Text, out double resultat))
            {
                obligationsZins = resultat;
            }
            else
            {
                l_ausgabe.Text = "Fehlerhafter Zins!";
                return;
            }

            double durchschnittsRenditeObligationen = obligationsZins / 100;
            DateTime datumZielErreichtObligationen = DateTime.Now.AddDays((int)(BerechneJahreUmZielKapitalZuErreichen(anfangskapital, vermoegensziel, durchschnittsRenditeObligationen) * 365));
            double durchschnittsRendite3 = (durchschnittsRenditeImmobilien + durchschnittsRenditeObligationen) / 2;
            DateTime datumZielErreicht3 = DateTime.Now.AddDays((int)(BerechneJahreUmZielKapitalZuErreichen(anfangskapital, vermoegensziel, durchschnittsRendite3) * 365));
            double durchschnittsVarianz3 = durchschnittsVarianzImmobilien / 2;
            double durchschnittsKorrelation3 = durchschnittsKorrelationImmobilien / 2;
            double Gesamtwertung3 = Math.Round(BerechneGesamtwertung(durchschnittsVarianz3, durchschnittsKorrelation3, (datumZielErreicht3 - DateTime.Now).Days), 3);

            l_vK_3.Text = "Verteilung Kapital: Immobilien 50%, Obligationen 50%";
            l_kW_3.Text = "Erwartetes Kapital bei Wunschdatum: " + Math.Round(BerechneZukuenftigesKapitalMitTagen(anfangskapital, durchschnittsRendite3, tage.Days)).ToString() + " CHF";
            l_dV_3.Text = "Datum bei Erreichen des Vermögensziels: " + DateOnly.FromDateTime(datumZielErreicht3);
            l_jR_3.Text = "Erwartete jährliche Rendite: " + Math.Round(durchschnittsRendite3, 2);
            l_v_3.Text = "Varianz: " + durchschnittsVarianz3;
            l_k_3.Text = "Korrelation: " + Math.Round(durchschnittsKorrelation3, 2);
            l_gb_3.Text = "Gesamtbewertung: " + Gesamtwertung3;

            if (datumZielErreicht3 <= dtp_zieldatum.Value)
            {
                l_sS_3.Visible = true;
            }
            else if (datumZielErreicht2 <= dtp_zieldatum.Value)
            {
                l_sS_2.Visible = true;
            }
            else
            {
                l_sS_1.Visible = true;
            }
        }
    }
}
