class Complex <T>{
    public T Real { get; set; }
    public T Imaginary { get; set; }

    public Complex(T real, T imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public T GetRealPart()
    {
        return Real;
    }

    public T GetImaginaryPart()
    {
        return Imaginary;
    }
}
