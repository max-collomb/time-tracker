using System;
using System.Collections.Generic;

namespace time_tracker
{

  /// <summary>
  /// Calendrier des jours ouvrés et fériés français
  /// https://github.com/pmiossec/miscellaneous/blob/master/C%23/Calendrier_Francais/Calendar.cs
  /// </summary>
  public static class Calendar
  {
    /// <summary>
    /// Retourne La date de Paques
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    private static DateTime Paques(int year)
    {
      int a = year % 19;
      int b = year / 100;
      int c = (b - (b / 4) - ((8 * b + 13) / 25) + (19 * a) + 15) % 30;
      int d = c - (c / 28) * (1 - (c / 28) * (29 / (c + 1)) * ((21 - a) / 11));
      int e = d - ((year + (year / 4) + d + 2 - b + (b / 4)) % 7);
      int mois = 3 + ((e + 40) / 44);
      int jour = e + 28 - (31 * (mois / 4));
      return new DateTime(year, mois, jour);
    }

    /// <summary>
    /// Lundi de paques
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    private static DateTime PaquesLundi(int year)
    {
      return Paques(year).AddDays(1);
    }

    /// <summary>
    /// La date De l'Ascenssion
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    private static DateTime Ascension(int year)
    {
      return Paques(year).AddDays(39);
    }

    /// <summary>
    /// Pentecote
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    private static DateTime Pentecote(int year)
    {
      return Paques(year).AddDays(49);
    }

    /// <summary>
    /// Lundi de Pentecote
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    private static DateTime PentecoteLundi(int year)
    {
      return Paques(year).AddDays(50);
    }

    /// <summary>
    /// Liste des jours feriés
    /// </summary>
    /// <param name="year">l'anné dont on veut la liste des jours feriés</param>
    /// false sinon</param>
    /// <returns>Liste des jours feriés</returns>
    public static Dictionary<String, DateTime> GetHolidays(int year)
    {
      var holidays = new Dictionary<string, DateTime>();

      // 1er mai (fête du Travail)
      holidays.Add("1er mai", new DateTime(year, 5, 1));

      // 8er mai (Armistice 1945)
      holidays.Add("8 mai", new DateTime(year, 5, 8));

      // 14 juillet (fête nationale)
      holidays.Add("14 juillet", new DateTime(year, 7, 14));

      // 15 août (Assomption)
      holidays.Add("15 août", new DateTime(year, 8, 15));

      // 1er novembre (Toussaint)
      holidays.Add("Toussaint", new DateTime(year, 11, 1));

      // 11 Novembre (Armistice 1918)
      holidays.Add("11 Novembre", new DateTime(year, 11, 11));

      // 25 décembre (Noël)
      holidays.Add("Noël", new DateTime(year, 12, 25));
      //(****************************** Fêtes mobiles *********************************
      // Pâques
      //listDate.Add(Paques(year));

      // Lundi de Pâques (lundi après Pâques)
      holidays.Add("Pâques", PaquesLundi(year));

      // Ascension (6e jeudi (39j) après Pâques)
      holidays.Add("Ascension", Ascension(year));

      // Pentecôte (7e dimanche (49j) après Pâques)
      //holidays.Add(Pentecote(year));

      // Lundi de la Pentecôte (lundi après la Pentecôte)
      holidays.Add("Pentecôte", PentecoteLundi(year)); //Ce n'est plus une date fériée

      // jour de l'an
      holidays.Add("Jour de l'an", new DateTime(year + 1, 1, 1));

      return holidays;
    }
  }
}
