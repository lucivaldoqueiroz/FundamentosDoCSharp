namespace Modulo11;
public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2012, 12, 01, 19, 22, 23);
        var date2 = DateTime.Parse("2023/01/06 19:25:23");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));

         var dateoffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
          Console.WriteLine(dateoffset1.LocalDateTime);
          Console.WriteLine(dateoffset1.UtcDateTime);
    }

    public void AulaSubstraindoDatas()
    {
      
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2022-01-01");

        var diff = date1 - date2;
        var diff2 = date1.Subtract(date2);

        Console.WriteLine((int)diff.TotalDays);
        Console.WriteLine((int)diff.TotalHours);
        Console.WriteLine(diff2);
    }

      public void AdicionandoDiaMesEAno()
    {
      
        var date1 = DateTime.Now;

        Console.WriteLine(date1.AddDays(5).ToString("dd-mm-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddMonths(5));
        Console.WriteLine(date1.AddYears(5));
    }

      public void AdicionandoHoraMinutosSegundos()
    {
      
        var date1 = DateTime.Now;


        
        Console.WriteLine(date1.ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddHours(1).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddMinutes(10).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddSeconds(10).ToString("HH:mm:ss"));
        
    }

    public void RecuperandoDiaDaSemana()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.DayOfWeek);

    }

    public void AulaDateOnly()
    {
        var somenteData = new DateOnly(2022,12,2);
        var somenteData1 = DateOnly.Parse("2022-02-01");

        Console.WriteLine(somenteData);
        Console.WriteLine(somenteData1);
        
        
    }

     public void AulaTimeOnly()
    {
        var somenteTime = new TimeOnly(22,50,22);
        var somenteTime2 = TimeOnly.Parse("23:55:01");

        Console.WriteLine(somenteTime);
        Console.WriteLine(somenteTime2);
        
        
    }

}
