using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Porject_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer tmrMove = new DispatcherTimer();

        int timer = 61;

        decimal prijsfiets = 0.00m;
        decimal fietsprijs = 0.00m;

        decimal verzekeringfiets = 0.00m;
        decimal verzekeringprijs = 0.00m;

        decimal servicefiets = 0.00m;
        decimal serviceprijs = 0.00m;

        decimal aantalf = 1;
        decimal aantalv = 1;
        decimal aantals = 1;

        decimal totaalf = 0.00m;
        decimal totaalv = 0.00m;
        decimal totaals = 0.00m;

        decimal eindtotaal = 0.00m;

        public MainWindow()
        {
            InitializeComponent();
            InitialiseTimers();
        }

        private void InitialiseTimers()
        {
            tmrMove.Interval = TimeSpan.FromSeconds(1);
            tmrMove.Tick += TmrMove_Tick;
            tmrMove.Start();
        }

            private void TmrMove_Tick(object sender, EventArgs e)
            {
            if (timer > 0)
            {
                timer--;
                timerlbl.Text = string.Format("{1}", timer/61, timer%61);
            }
            else
            {
                Application.Current.Shutdown();
            }
            }

            private void fietscombo(object sender, SelectionChangedEventArgs e)
            {
                ComboBoxItem fietscombos = (ComboBoxItem)fietscombow.SelectedItem;
                string fietscombobox = fietscombos.Content.ToString();

            aantalf = 1;

                timer = 61;

                    switch (fietscombobox)
                    {
                    case "Aanhangfiets":
                        fietsprijs = 20.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Bakfiets":
                        fietsprijs = 35.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Driewielfiets":
                        fietsprijs = 30.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Elektrische fiets":
                        fietsprijs = 30.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Kinderfiets":
                        fietsprijs = 15.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Ligfiets":
                        fietsprijs = 45.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Oma fiets":
                        fietsprijs = 12.50m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Racefiets":
                        fietsprijs = 15.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Speed pedelec":
                        fietsprijs = 15.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Stadsfiets":
                        fietsprijs = 12.50m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Vouwfiets":
                        fietsprijs = 10.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    case "Zitfiets":
                        fietsprijs = 15.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                    default:
                        fietsprijs = 0.00m;
                        prijsfiets = fietsprijs;
                        prijsfietsen.Text = "€" + prijsfiets;
                        break;
                }
        }

        private void btnpfiets_Click(object sender, RoutedEventArgs e)
        {
            timer = 61;
            prijsfiets += fietsprijs;
            prijsfietsen.Text = "€" + prijsfiets;
            aantalf += 1;
        }

        private void btnmfiets_Click(object sender, RoutedEventArgs e)
        {
            timer = 61;
            if (prijsfiets > fietsprijs)
            { 
                prijsfiets -= fietsprijs;
                prijsfietsen.Text = "€" + prijsfiets;
                aantalf -= 1;
            }
            else
            {
                MessageBox.Show("Lager kan je niet gaan!");
            }
        }

        private void verzekeringencombo(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem verzekeringen = (ComboBoxItem)verzekeringencombos.SelectedItem;
            string verzekering = verzekeringen.Content.ToString();
            timer = 61;
            aantalv = 1;

            switch (verzekering)
            {
                case "Beschadigingen":
                    verzekeringfiets = 5.00m;
                    verzekeringprijs = verzekeringfiets;
                    prijsverzekeringen.Text = "€" + verzekeringprijs;
                    break;
                case "Diefstal":
                    verzekeringfiets = 10.00m;
                    verzekeringprijs = verzekeringfiets;
                    prijsverzekeringen.Text = "€" + verzekeringprijs;
                    break;
                case "Rechtsbijstand":
                    verzekeringfiets = 5.00m;
                    verzekeringprijs = verzekeringfiets;
                    prijsverzekeringen.Text = "€" + verzekeringprijs;
                    break;
                case "Ongevallen":
                    verzekeringfiets = 2.50m;
                    verzekeringprijs = verzekeringfiets;
                    prijsverzekeringen.Text = "€" + verzekeringprijs;
                    break;
                default:
                    verzekeringfiets = 0.00m;
                    verzekeringprijs = verzekeringfiets;
                    prijsverzekeringen.Text = "€" + verzekeringprijs;
                    break;
            }
        }

        private void btnpverzeker_Click(object sender, RoutedEventArgs e)
        {
            timer = 61;
            verzekeringprijs += verzekeringfiets;
            prijsverzekeringen.Text = "€" + verzekeringprijs;
            aantalv += 1;
        }

        private void btnmverzeker_Click(object sender, RoutedEventArgs e)
        {
            timer = 61;
            if (verzekeringprijs > verzekeringfiets)
            {
                verzekeringprijs -= verzekeringfiets;
                prijsverzekeringen.Text = "€" + verzekeringprijs;
                aantalv -= 1;
            }
            else
            {
                MessageBox.Show("Lager kan je niet gaan!");
            }
        }

        private void servicescombo(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem services = (ComboBoxItem)servicescombos.SelectedItem;
            string service = services.Content.ToString();
            timer = 61;
            aantals = 1;

            switch (service)
            {
                case "Ophaalservice":
                    servicefiets = 15.00m;
                    serviceprijs = servicefiets;
                    prijsservices.Text = "€" + serviceprijs;
                    break;
                case "Regenpak":
                    servicefiets = 10.00m;
                    serviceprijs = servicefiets;
                    prijsservices.Text = "€" + serviceprijs;
                    break;
                case "Lunchpakket basis":
                    servicefiets = 12.50m;
                    serviceprijs = servicefiets;
                    prijsservices.Text = "€" + serviceprijs;
                    break;
                case "Lunchpakket uitgebreid":
                    servicefiets = 20.00m;
                    serviceprijs = servicefiets;
                    prijsservices.Text = "€" + serviceprijs;
                    break;
                default:
                    servicefiets = 0.00m;
                    serviceprijs = servicefiets;
                    prijsservices.Text = "€" + serviceprijs;
                    break;
            }
        }

        private void btnpservice_Click(object sender, RoutedEventArgs e)
        {
            timer = 61;
            serviceprijs += servicefiets;
            prijsservices.Text = "€" + serviceprijs;
            aantals += 1;
        }

        private void btnmservice_Click(object sender, RoutedEventArgs e)
        {
            timer = 61;
            if (serviceprijs > servicefiets)
            {
                serviceprijs -= servicefiets;
                prijsservices.Text = "€" + serviceprijs;
                aantals -= 1;
            }
            else
            {
                MessageBox.Show("Lager kan je niet gaan!");
            }

        }

        private void Toevoegen_Click(object sender, RoutedEventArgs e)
        {
                timer = 61;
                //fietscombow.Text = String.Empty; verzekeringencombos.Text = String.Empty; servicescombos.Text = String.Empty;

                if (!string.IsNullOrEmpty(fietscombow.Text))
                {
                ComboBoxItem fietscombos = (ComboBoxItem)fietscombow.SelectedItem;
                string fietscombobox = fietscombos.Content.ToString();

                if (fietscombobox == "Aanhangfiets" | fietscombobox == "Bakfiets" | fietscombobox == "Driewielfiets" | fietscombobox == "Elektrische fiets" | fietscombobox == "Kinderfiets" | fietscombobox == "Ligfiets" | fietscombobox == "Oma fiets" | fietscombobox == "Racefiets" | fietscombobox == "Speed pedelec" | fietscombobox == "Stadsfiets" | fietscombobox == "Vouwfiets" | fietscombobox == "Zitfiets")
                {
                    totaalf = prijsfiets;
                    lboverzicht.Items.Add("X" + aantalf + " " + fietscombobox + " €" + totaalf);
                    eindtotaal += totaalf;
                }
                }

                if (!string.IsNullOrEmpty(verzekeringencombos.Text))
                {
                ComboBoxItem verzekeringen = (ComboBoxItem)verzekeringencombos.SelectedItem;
                string verzekering = verzekeringen.Content.ToString();

                if (verzekering == "Beschadigingen" | verzekering == "Diefstal" | verzekering == "Rechtsbijstand" | verzekering == "Ongevallen")
                {
                    totaalv = verzekeringprijs;
                    lboverzicht.Items.Add("X" + aantalv + " " + verzekering + " €" + totaalv);
                    eindtotaal += totaalv;
                }
                }


                if (!string.IsNullOrEmpty(servicescombos.Text))
                {
                ComboBoxItem services = (ComboBoxItem)servicescombos.SelectedItem;
                string service = services.Content.ToString();

                if (service == "Ophaalservice" | service == "Regenpak" | service == "Lunchpakket basis" | service == "Lunchpakket uitgebreid")
                {
                    totaals = serviceprijs;
                    lboverzicht.Items.Add("X" + aantals + " " + service + " €" + totaals);
                    eindtotaal += totaals;
                }
                }
                eindtotalen.Text = "€" + eindtotaal;
        }

        private void verwijderen_Click(object sender, RoutedEventArgs e)
        {
            timer = 61;
            if (lboverzicht.SelectedItem != null)
            {
                string selecteditem = lboverzicht.SelectedItem.ToString();
                string[] splitted = selecteditem.Split('€');
                decimal geld = decimal.Parse(splitted[1]);
                eindtotaal -= geld;
                lboverzicht.Items.Remove(lboverzicht.SelectedItem);
                eindtotalen.Text = "€" + eindtotaal;
            }
            else
            {
                MessageBox.Show("Niets in de listbox");
            }
        }

        private void betalen_Click(object sender, RoutedEventArgs e)
        {
            //PrintDialog myPrintDialog = new PrintDialog();
            //if (myPrintDialog.ShowDialog() == true)
            //{
            //    myPrintDialog.PrintVisual(lboverzicht, "Listbox Items Print");
            //}

            timer = 61;
            MessageBox.Show("€" + eindtotaal);
        }

        private void lboverzicht_select(object sender, SelectionChangedEventArgs e)
        {
            timer = 61;
        }
    }
}