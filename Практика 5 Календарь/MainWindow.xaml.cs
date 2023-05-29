// Класс модели данных для записей календаря
using System.Collections.Generic;
using System.Security.Claims;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using System.Windows;
using System;

public class CalendarEntry
{
    public DateTime Date { get; set; }
    public string Activity { get; set; }
    // Другие свойства записи

    public CalendarEntry(DateTime date, string activity)
    {
        Date = date;
        Activity = activity;
    }
}

// Класс управления календарем
public class CalendarManager
{
    private List<CalendarEntry> entries;
    private DateTime selectedDate;

    public CalendarManager()
    {
        entries = new List<CalendarEntry>();
        selectedDate = DateTime.Now;
    }

    public void ChangeMonth(int monthOffset)
    {
        selectedDate = selectedDate.AddMonths(monthOffset);
        // Обновить данные календаря
    }

    public void AddEntry(DateTime date, string activity)
    {
        CalendarEntry newEntry = new CalendarEntry(date, activity);
        entries.Add(newEntry);
        // Сохранить запись в файл JSON или XML
    }

    public void UpdateEntry(CalendarEntry entry, string activity)
    {
        entry.Activity = activity;
        // Сохранить измененную запись в файл JSON или XML
    }

    public void DeleteEntry(CalendarEntry entry)
    {
        entries.Remove(entry);
        // Удалить запись из файла JSON или XML
    }

    public CalendarEntry GetEntryByDate(DateTime date)
    {
        return entries.FirstOrDefault(e => e.Date.Date == date.Date);
    }

    // Другие методы для работы с записями календаря
}

< Window x: Class = "CalendarApp.MainWindow"
        xmlns = "http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns: x = "http://schemas.microsoft.com/winfx/2006/xaml"
        Title = "Calendar App" Height = "450" Width = "800" >
    < Grid >
        < !--Разметка для отображения календаря и списков записей -->
    </Grid>
</Window>
