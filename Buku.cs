namespace MyNamespace
{
  class Buku
  {
    private readonly string judul;
    private readonly string penulis;
    private readonly string tahunTerbit;
    private readonly int jumlahHalaman;
    private int jumlahKopi;
    private int jumlahKopiTersedia = 0;

    public Buku(string judul, string penulis, string tahunTerbit, int jumlahHalaman, int jumlahKopi)
    {
      this.judul = judul;
      this.penulis = penulis;
      this.tahunTerbit = tahunTerbit;
      this.jumlahHalaman = jumlahHalaman;
      this.jumlahKopi = jumlahKopi;
      jumlahKopiTersedia = jumlahKopi;
    }

    public void ShowInfo()
    {
      Console.WriteLine("Judul: " + judul);
      Console.WriteLine("Penulis: " + penulis);
      Console.WriteLine("Tahun Terbit: " + tahunTerbit);
      Console.WriteLine("Jumlah Halaman: " + jumlahHalaman);
      Console.WriteLine("Jumlah Kopi: " + jumlahKopi);
      Console.WriteLine("Jumlah Kopi Tersedia: " + jumlahKopiTersedia);
    }

    public bool PinjamBuku()
    {
      if (jumlahKopiTersedia > 0)
      {
        jumlahKopiTersedia--;
        Console.WriteLine("Buku berhasil dipinjam");
        return true;
      }
      Console.WriteLine("Buku sedang habis");
      return false;
    }

    public bool Rusak(int jumlahKopi)
    {
      int minus = this.jumlahKopi - jumlahKopi;
      if (minus <= 0)
      {
        Console.WriteLine("Buku rusak tidak sesuai dengan jumlah kopi yang ada");
        return false;
      }
      this.jumlahKopi = minus;
      jumlahKopiTersedia -= jumlahKopi;
      if (jumlahKopiTersedia < 0)
      {
        jumlahKopiTersedia = 0;
      }
      return true;
    }

    public void KembalikanBuku(int jumlahKopi)
    {
      jumlahKopiTersedia += jumlahKopi;
      Console.WriteLine("Buku berhasil dikembalikan");
    }

    public int GetJumlahKopiTersedia()
    {
      return jumlahKopiTersedia;
    }

    public int GetJumlahKopi()
    {
      return jumlahKopi;
    }

    public int GetJumlahDipinjam()
    {
      return jumlahKopi - jumlahKopiTersedia;
    }
  }


}
