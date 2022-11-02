using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation
{
    /// <summary>
    /// La classe voiture permet de modifier la couleur du véhicule choisi.
    /// Ensuite, la classe permet de déterminer si la véhicule doit être changer ou conservé.
    /// </summary>
    public class Voiture
    {
      
      
        private string couleur;
        private string marque;
        private int annee;
        private decimal kilometrage;
        private int nombrePorte;

        public string Couleur { get => couleur; set => couleur = value; }

        /// <summary>
        /// L'évenément est déclencher lorsque la couleur du véhicule change
        /// </summary>
        public event EventHandler<string> couleurChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="couleur"></param>
        /// <param name="marque"></param>
        /// <param name="annee"></param>
        /// <param name="kilometrage"></param>
        /// <param name="nombrePorte"></param>
        public Voiture(string couleur, string marque, int annee, decimal kilometrage, int nombrePorte)
        {
            
            this.couleur = couleur;
            this.marque = marque;
            this.annee = annee;
            this.kilometrage = kilometrage;
            this.nombrePorte = nombrePorte; 
        }


        /// <summary>
        /// La méthode Peinture(), est utilisé pour changer la peinture originale de la voiture.
        /// Puis, elle prend la peinture initiale et la change  pour  la peinture choisie.
        /// L'évènement couleurChanged met à jour automatiquement la couleur choisie comme la nouvelle couleur de la voiture.
        /// </summary>
        /// <param name="couleurFinale">La couleur finale du véhicule</param>


        private void Peinture(string couleurFinale) 
        {
          
            this.Couleur = couleurFinale;


            couleurChanged.Invoke(this, couleurFinale);
        }


        /// <summary>
        /// La porte ChangementVoiture, est utilisée pour pouvoir déterminer si un véhicule doit être changer.
        /// Si, le kilomètrage de la voiture est supérieur à 9999999 la méthode retourne un message important sinon le véhicule est encore bon.
        /// </summary>
        /// <returns>si le véhicule a 9999999 kilo il devrait être changer  sinon il pourra être garder</returns>
        private string ChangementVoiture(decimal kilo) 
        {
            kilo = this.kilometrage;
            if (kilo > 999999)
            {
                return "Oh lala votre véhicule doit être changer au plus vite";
            }
            else
            {
                return "Encore bon";
            }   
        }
       



    }
}
