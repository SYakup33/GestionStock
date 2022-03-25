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
    /// Logique d'interaction pour AnneeExerciceForm.xaml
    /// </summary>
    public partial class AnneeExerciceForm : Window
    {
        public void refresh()
        {
            AnneeExerciceControleur controle = new AnneeExerciceControleur();
            Grille.ItemsSource = controle.show();
        }

        public AnneeExerciceForm()
        {
            InitializeComponent();
            refresh();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (AnneeExerciceFrom.SelectedDate != null)
            {
                AnneeExercice anneeExercice = new AnneeExercice(AnneeExerciceFrom.SelectedDate.Value.ToString("yyyy-MM-dd"));
                new AnneeExerciceControleur().add(anneeExercice);
            }
            refresh();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grille_Initialized(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
