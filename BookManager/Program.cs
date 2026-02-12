using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DigitalBookViewer
{
    // ✅ Point d'entrée de l'application
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configuration de l'application Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lancer le formulaire principal
            Application.Run(new Form1());
        }
    }

    // ✅ Classe de gestion du livre numérique
    public class BookManager
    {
        private List<string> pages = new List<string>();
        private int currentPage = 0;

        // Charger toutes les pages à partir d’un dossier
        public void LoadBook(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException("Dossier non trouvé.");
            }

            var files = Directory.GetFiles(folderPath, "*.txt");
            Array.Sort(files); // Tri alphabétique des fichiers
            pages.Clear();

            foreach (var file in files)
            {
                pages.Add(File.ReadAllText(file));
            }

            currentPage = 0;
        }

        // Retourner le contenu de la page actuelle
        public string GetCurrentPage()
        {
            if (pages.Count == 0)
                return "Aucune page chargée.";
            return pages[currentPage];
        }

        // Aller à la page suivante
        public string NextPage()
        {
            if (currentPage < pages.Count - 1)
                currentPage++;
            return GetCurrentPage();
        }

        // Aller à la page précédente
        public string PreviousPage()
        {
            if (currentPage > 0)
                currentPage--;
            return GetCurrentPage();
        }

        // Aller à une page spécifique
        public string GoToPage(int pageNumber)
        {
            if (pageNumber < 1 || pageNumber > pages.Count)
                throw new ArgumentOutOfRangeException("Numéro de page invalide.");
            currentPage = pageNumber - 1;
            return GetCurrentPage();
        }

        // Obtenir le nombre total de pages
        public int GetTotalPages()
        {
            return pages.Count;
        }

        // Obtenir le numéro de la page actuelle (1-based)
        public int GetCurrentPageNumber()
        {
            return currentPage + 1;
        }
    }
}
