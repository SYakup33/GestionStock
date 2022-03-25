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
using System.Windows.Shapes;
using GestionStock.model;
using GestionStock.contrôleur;

namespace GestionStock.vue
{
    /// <summary>
    /// Logique d'interaction pour FournisseurForm.xaml
    /// </summary>
    public partial class FournisseurForm : Window
    {
        //private FournisseurForm fournisseur;
        // méthode pour rafraichir la grille, base de données
        private FournisseurControle controller;
        private Fournisseur fournisseur;
        public void refresh()
        {
            controller = new FournisseurControle();
            this.fournisseur = new Fournisseur();
            FournisseurControle controle = new FournisseurControle();
            Grille.ItemsSource = controle.show();
        }
        public FournisseurForm()
        {
            InitializeComponent();
            controller = new FournisseurControle();
            this.fournisseur = new Fournisseur();
            refresh();
        }

    

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Fournisseur fournisseur = new Fournisseur(fournisseurNom.Text, contactNom.Text, contactTitre.Text, adresse.Text, ville.Text,codePostale.Text, paysOuRegion.Text, departementOuRegion.Text, tel.Text, fax.Text, Int32.Parse(paiement.Text),email.Text,remarques.Text);
            new FournisseurControle().add(fournisseur);
            refresh();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Fournisseur fournisseur = new Fournisseur(fournisseurNom.Text, contactNom.Text, contactTitre.Text, adresse.Text, ville.Text, codePostale.Text, paysOuRegion.Text, departementOuRegion.Text, tel.Text, fax.Text, Int32.Parse(paiement.Text), email.Text, remarques.Text);
            fournisseur.RefFournisseur = this.fournisseur.RefFournisseur;
            new FournisseurControle().edit(fournisseur);
            refresh();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            new FournisseurControle().delete(fournisseur);
            refresh();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grille_Initialized(object sender, EventArgs e)
        {
            refresh();
        }


        private void Grille_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.fournisseur = new Fournisseur();
            if(Grille.SelectedItem is Fournisseur)
            this.fournisseur = (Fournisseur)Grille.SelectedItem;
            if (this.fournisseur != null && Grille.SelectedItem is Fournisseur)
            {
                Fournisseur fournisseur = (Fournisseur)Grille.SelectedItem;
                fournisseurNom.Text = fournisseur.NomFournisseur;
                contactNom.Text = fournisseur.NomContact;
                contactTitre.Text = fournisseur.TitreContact;
                adresse.Text = fournisseur.Adresse;
                ville.Text = fournisseur.Ville;
                codePostale.Text = fournisseur.CodePostal;
                departementOuRegion.Text = fournisseur.DepartementOuRegion;
                paysOuRegion.Text = fournisseur.PaysOuRegion;
                tel.Text = fournisseur.NumeroTel;
                fax.Text = fournisseur.Fax;
                paiement.Text = "" + fournisseur.ConditionPaiement;
                email.Text = fournisseur.Email;
                remarques.Text = fournisseur.Remarques;
            }
        }
    }
}
