using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPTE_09_09_2022
{
    internal class Compte
    {
        private int numero;
        private string nomProprio;
        private int solde;
        private int montantDecouvert;


        public Compte()
        {
            this.numero = 0;
            this.nomProprio = "";
            this.solde = 0;
            this.montantDecouvert = 0;
        }


        public Compte(int numero, string nomProprio, int solde, int montantDecouvert)
        {
            this.numero = numero;
            this.nomProprio = nomProprio;
            this.solde = solde;
            this.montantDecouvert = montantDecouvert;
        }

        public int getNumero()
        {
            return this.numero;
        }


        public string getNom()
        {
            return nomProprio;
        }

        public int getSolde()
        {
            return solde;
        }

        public int getDecouvertAutorise()
        { 
            return montantDecouvert; 
        }

        public int leSolde()
        {
            return this.solde;
        }

        public int crediter(int somme)
        {
            this.solde = this.solde + somme;
            return this.solde;
        }

        public bool debiter(int montant)
        {
            if ((this.solde + this.montantDecouvert * -1) < montant)

            {
                if (this.solde >= montant)
                {
                    this.solde = this.solde - montant;
                    return true;

                }
                else
                {
                    this.montantDecouvert = this.montantDecouvert - (this.solde - montant);
                    this.solde = 0;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool transferer(int montantATransferer)
            {
                if ((this.solde + this.montantDecouvert * -1) < montantATransferer)

                {
                    if (this.solde >= montantATransferer)
                    {
                        this.solde = this.solde - montantATransferer;
                        return true;

                    }
                    else
                    {
                        this.montantDecouvert = this.montantDecouvert - (this.solde - montantATransferer);
                        this.solde = 0;
                        return true;
                    }

                }
                else
                {
                    return false;
                }
            }
        public override string ToString()
        {
            return "Numéro : " + this.numero + Environment.NewLine + "nom : " + this.nomProprio + Environment.NewLine + "Solde : " + this.solde + Environment.NewLine + "Découvert autorisé : " + this.montantDecouvert;

        }
    }
}
