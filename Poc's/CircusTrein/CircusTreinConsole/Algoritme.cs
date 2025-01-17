﻿using CircusTrein;
using CircusTrein.Application;
using System;
using System.Collections.Generic;

namespace CircusTrein
{
    public class Algoritme
    {
        public static Dier AddAnimal(string naam, string dieet, string grote)
        {
            Dier dier;
            int voedselKeuze = int.Parse(dieet);
            int groteKeuze = int.Parse(grote);
            dier = new Dier(naam, (Dier.Dieet)voedselKeuze, (Dier.Grote)groteKeuze);
            return dier;
        }
        public static List<Wagon> RunAlgoritme(List<Dier> dieren)
        {
            int wagonCounter = 1;
            List<Wagon> wagonLijstIncompleet = new List<Wagon>();
            List<Wagon> wagonLijstCompleet = new List<Wagon>();

            List<Dier> dierenTemp = new List<Dier>();
            //Iedere carnivoor een wagon geven
            foreach (Dier dier in dieren)
            {
                if (dier.diet == Dier.Dieet.carnivoor)
                {
                    Wagon wagon = new Wagon(wagonCounter++);
                    switch (dier.size)
                    {
                        case Dier.Grote.groot:
                            wagon.addDierAanWagon(dier);
                            wagonLijstCompleet.Add(wagon);
                            break;
                        default:
                            wagon.addDierAanWagon(dier);
                            wagonLijstIncompleet.Add(wagon);
                            break;
                    }
                }
                else
                {
                    dierenTemp.Add(dier);
                }
            }
            dieren.Clear();
            foreach (Dier dier in dierenTemp)
            {
                dieren.Add(dier);
            }
            dierenTemp.Clear();

            //Iedere middel carnivoor een grote herbivoor geven
            foreach (Dier dier in dieren)
            {
                if (dier.size == Dier.Grote.groot)
                {
                    bool dierToegevoegd = false;
                    foreach (Wagon wagon in wagonLijstIncompleet)
                    {
                        if (wagon.HuidigeGrote == 3) //is dit een wagon met een middel carnivoor?
                        {
                            wagon.addDierAanWagon(dier);
                            wagonLijstCompleet.Add(wagon);
                            wagonLijstIncompleet.Remove(wagon);
                            dierToegevoegd = true;
                            break;
                        }
                    }
                    if (!dierToegevoegd)
                    {
                        dierenTemp.Add(dier);
                    }
                }
                else
                {
                    dierenTemp.Add(dier);
                }
            }
            dieren.Clear();
            foreach (Dier dier in dierenTemp)
            {
                dieren.Add(dier);
            }
            dierenTemp.Clear();

            //alle overige wagons met middel carnivoren naar de complete lijst zetten
            List<Wagon> wagonTemp = new List<Wagon>();
            foreach (Wagon wagon in wagonLijstIncompleet)
            {
                if (wagon.HuidigeGrote == 3)
                {
                    wagonLijstCompleet.Add(wagon);
                }
                else
                {
                    wagonTemp.Add(wagon);
                }
            }
            wagonLijstIncompleet.Clear();
            foreach (Wagon wagon in wagonTemp)
            {
                wagonLijstIncompleet.Add(wagon);
            }
            wagonTemp.Clear();

            //iedere wagon met een kleine carnivoor opvullen met de overige grote herbivoren 
            foreach (Dier dier in dieren)
            {
                if (dier.size == Dier.Grote.groot)
                {
                    bool dierToegevoegd = false;
                    foreach (Wagon wagon in wagonLijstIncompleet)
                    {
                        if (wagon.HuidigeGrote == 1) //is dit een wagon met alleen 1 kleine carnivoor?
                        {
                            wagon.addDierAanWagon(dier);
                            dierToegevoegd = true;
                            break;
                        }
                    }
                    if (!dierToegevoegd)
                    {
                        dierenTemp.Add(dier);
                    }
                }
                else
                {
                    dierenTemp.Add(dier);
                }
            }
            dieren.Clear();
            foreach (Dier dier in dierenTemp)
            {
                dieren.Add(dier);
            }
            dierenTemp.Clear();

            //iedere wagon met een kleine carnivoor zo effiecent mogelijk opvullen
            foreach (Dier dier in dieren)
            {
                if (dier.size == Dier.Grote.middel)
                {
                    bool dierToegevoegd = false;
                    foreach (Wagon wagon in wagonLijstIncompleet)
                    {
                        if (wagon.HuidigeGrote <= 7) //kan er nog een middel herbivoor bij
                        {
                            wagon.addDierAanWagon(dier);
                            wagonLijstCompleet.Add(wagon);
                            wagonLijstIncompleet.Remove(wagon);
                            dierToegevoegd = true;
                            break;
                        }
                    }
                    if (!dierToegevoegd)
                    {
                        dierenTemp.Add(dier);
                    }
                }
                else
                {
                    dierenTemp.Add(dier);
                }
            }
            dieren.Clear();
            foreach (Dier dier in dierenTemp)
            {
                dieren.Add(dier);
            }
            dierenTemp.Clear();

            // de lijst van dieren sorteren op grote, 
            //dit is omdat er alleen nog maar herbivoren zijn en deze moeten zo efficient mogelijk geplaatst worden in wagons
            //en nu kan je de lijst van boven naar beneden doorlopen en dieren toevoegen tot er geen plek meer is
            dieren = sorteerDierenOpGrote(dieren);

            //overige herbivoren zo efficient opdelen over wagons
            foreach (Dier dier in dieren)
            {
                if (wagonLijstIncompleet.Count == 0)
                {
                    wagonLijstIncompleet.Add(new Wagon(wagonCounter++));
                }
                foreach (Wagon wagon in wagonLijstIncompleet)
                {
                    if ((wagon.HuidigeGrote + (int)dier.size) <= 10) //is er plek voor een grote herbivoor?
                    {
                        wagon.addDierAanWagon(dier);
                        break;
                    }
                }
            }
            foreach (Wagon wagon in wagonLijstIncompleet)
            {
                wagonLijstCompleet.Add(wagon);
            }


            return wagonLijstCompleet;

        }

        static List<Dier> sorteerDierenOpGrote(List<Dier> lijst)
        {
            List<Dier> dierSwitchList = new List<Dier>();
            foreach (Dier dier in lijst)
            {
                dierSwitchList.Add(dier);
            }
            foreach (Dier dier in dierSwitchList)
            {
                for (int i = 0; i <= lijst.Count - 1; i++)
                {
                    for (int j = i + 1; j < lijst.Count; j++)
                    {
                        if (lijst[i].size < lijst[j].size)
                        {
                            Dier dierTemp = lijst[i];
                            lijst[i] = lijst[j];
                            lijst[j] = dierTemp;
                        }
                    }
                }
            }
            return lijst;
        }
    }
}
