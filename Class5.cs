struct Color
{
    public int R, G, B;

    public Color(int r, int g, int b)
    {
        this.R = r;
        this.G = g;
        this.B = b;
    }

    public override string ToString()
    {
        return($"RGB({R},{G},{B})");
    }
}
