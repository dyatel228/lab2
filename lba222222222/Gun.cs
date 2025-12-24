class Gun
{
    public int Bullets;

    public Gun(int bullets)
    {
        Bullets = bullets;
    }

    public Gun()
    {
        Bullets = 5;
    }

    public void Shoot()
    {
        if (Bullets > 0)
        {
            Console.WriteLine("Бах!");
            Bullets--;
        }
        else
        {
            Console.WriteLine("Клац!");
        }
    }

    public override string ToString()
    {
        return "Пистолет с " + Bullets + " патронами";
    }
}