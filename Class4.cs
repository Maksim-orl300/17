struct Weather
{
    public string City;
    public double? Temperature;

    public override string ToString()
    {
        string D = Temperature == null ? "Нет данных" : Temperature.ToString();
        return ($"{City}: {D}");
    }
}
