using Microsoft.VisualBasic;
using System;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Xml.Serialization;

namespace Jeu_du_Pendu
{
    public class Program 
    {
        static public bool isWin = false;
        static public bool menu = true;
        static public int essaisRestants = modeJeu;
        static public int modeJeu = 0;
        static public string lettreChoisie = "";
        static public string motChoisiString = "";
        static public int motChoisiInt;
        static public int range = 31;
        static public string[] mots = {"camion", "pendu", "microphone", "aventure", "poeme", "policier", "cigarette", "phoque", "citation", "virgule", "matraque", "helicoptere", "situation", "langue", "guillotine",
        "lampadaire", "ordinateur", "clavier", "souris", "baleine", "eglise", "ventilateur", "galaxy", "etoile", "alphabet", "artiste", "orange", "pissenlit", "tournesol", "abricot", "ballon","abracadabrant"};
        static public List<string> lettresTrouve = new List<string>();
        static public List<string> mauvaiseLettres = new List<string>();
        static public string motComplet = "";
        static public string badLetter = "";
        static bool lgn = true;
        static string name = "";
        static int point;
        static void Main(string[] args)
        {
            boucleJeu();
        }
        //Choisi un mot parmi la liste
        static void choixMot()
        {
            Random rnd = new Random();
            motChoisiInt = rnd.Next(range);
            motChoisiString = mots[motChoisiInt];
        }
        //Check if input is a letter
        static bool checkLettre(string lettreChoisie)
        {
            bool result = lettreChoisie.Any(char.IsLetter);
            return result;
        }
        //Boucle de gameplay
        static void boucleJeu()
        {           
            Console.Clear();     
            userScore newGame = new userScore();
            newGame.askUserName();

            if(menu)
            {
                difficulty();
            }
    
            if (lettresTrouve.Any() || mauvaiseLettres.Any())
            {    
                motComplet = "";
                lettreChoisie = "";
                lettresTrouve.Clear();
                mauvaiseLettres.Clear();
            }

            choixMot();

            IHM.regleEtTitre();
            IHM.showMessage(motChoisiString);//debug
            IHM.showMessage("Il y a " + motChoisiString.Length + " lettres dans ce mot");

            while (essaisRestants > 0 && !isWin)
            {            
                newGame.clacScore();
                newGame.outpout();         
                IHM.affichagePendu();
                IHM.showletter();                                     
                IHM.showMessage("Vous avez " + essaisRestants + " essais restants");
                IHM.showMessage("Tappez une lettre");
                    
                if(!checkIfWin())
                {           
                    lettreChoisie = Console.ReadLine();
                }

                int taille = lettreChoisie.Length;
                Console.Clear();
                    
                if (checkLettre(lettreChoisie))
                {   
                    if (motChoisiString.Contains(lettreChoisie) && taille == 1 && !lettresTrouve.Contains(lettreChoisie))   
                    {
                        lettresTrouve.Add(lettreChoisie);
                        IHM.showMessage("Trouvé !");    
                        point ++;                                             
                    }
                    else if (lettresTrouve.Contains(lettreChoisie) && taille == 1)
                    {
                        IHM.showMessage("Vous avez deja trouvé cette lettre");
                    }  
                    else if (taille > 1)                           
                    {     
                        IHM.showMessage("Entrez SEULEMNT 1 lettre svp"); 
                    }
                    else if (!motChoisiString.Contains(lettreChoisie))
                    {  
                        if (!mauvaiseLettres.Contains(lettreChoisie))
                        {
                            IHM.showMessage("Raté !");
                            mauvaiseLettres.Add(lettreChoisie);
                            essaisRestants--;
                            point --; 
                        }
                        else if (mauvaiseLettres.Contains(lettreChoisie))
                        {
                            IHM.showMessage("Vous avez deja trouvé cette lettre");
                        }
                    }
                }
                if(lettreChoisie == "menu")
                {
                    menu = true;
                    difficulty();                         
                }
                else if(!checkLettre(lettreChoisie))
                {
                    IHM.showMessage("Entrez une lettre svp");
                }               
            } 
            IHM.affichagePendu();  
            restart();                    
        }
        // System de restart du jeu
        static void restart()
        {
            bool rst = true;

            if(isWin == true)
            {
                IHM.win();
                IHM.showMessage("Voulez vous rejouer ? Y / N");
            }
            else if (essaisRestants == 0)
            {
                IHM.loose();
                IHM.showMessage("Voulez vous rejouer ? Y / N");
            }

            while(rst == true)
            {
                string YN = Console.ReadLine();

                if (YN == "y")
                {
                    essaisRestants = modeJeu;
                    isWin = false;
                    rst = false;
                    badLetter = "";
                    lettreChoisie = "";
                    motComplet = "";
                    Console.Clear();
                    boucleJeu();
                }
                else if (YN == "n")
                {
                    Console.Clear();
                    Environment.Exit(0);
                }   
                else if (YN == "menu")
                {
                    menu = true;
                    rst = false;
                    Console.Clear();
                    difficulty();
                }
                else
                {
                    IHM.showMessage("Tappez Y ou N svp");
                }
            } 
        }
        //check si le mot a été trouvé 
        static bool checkIfWin()
        {
            motComplet = string.Concat(lettresTrouve);

            string motChoisiStringCopy = motChoisiString;
            string motChoisiCoupe = String.Empty;
            for(int i=0; i<motChoisiStringCopy.Length; i++)
            {
                if (!motChoisiCoupe.Contains(motChoisiStringCopy[i]))
                {
                    motChoisiCoupe += motChoisiStringCopy[i];
                }
            }
            if(motComplet.Length == motChoisiCoupe.Length)
            {
                isWin = true;
            }
            return isWin;
        }  
        //Choisie mode du jeu
        static void difficulty()
        {
            IHM.modeDeJeu();
            
            while(menu == true)
            {
                string DN = Console.ReadLine();
                
                if(DN == "d")
                {
                    modeJeu = 3;  
                    menu = false;
                }
                else if(DN == "n")
                {        
                    modeJeu = 6;
                    menu = false;
                }
                else if(DN == "f")
                {
                    modeJeu = 10;
                    menu = false;
                }
                else
                {
                    IHM.showMessage("Tappez D, F ou N svp");
                }      
            }
            essaisRestants = modeJeu;
            Console.Clear(); 
            isWin = false;
            point = 0;
            boucleJeu();
        } 
        public class userScore
        {
            private string userName = name;
            private float score;

            public void askUserName()
            {
                while(lgn)
                {
                    IHM.showMessage("User name ? :"); 
                    name = Console.ReadLine();

                    if (checkLettre(name))
                    {
                        IHM.showMessage("User name : " + name);
                        lgn = false;
                    }
                    else 
                    {
                        IHM.showMessage("tapez seulement des lettres svp");
                    }
                }    
            }
            public void clacScore()
            {
                if(score >= 0)
                {
                    score = point * motChoisiString.Length;
                }
                else if (score < 0)
                {
                    score = 0;
                }
                
            }
            public void outpout()
            {
                IHM.showMessage("                       ");
                IHM.showMessage("User name : " + userName);
                IHM.showMessage("Score = " + score);
                IHM.showMessage("                       ");
            }
        }
    }
}