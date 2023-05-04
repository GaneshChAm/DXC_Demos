namespace EnumDemo
{
    internal class Program
    {
        enum MPlayer { play=10,pause,record,rewind,stop}
        static void Main(string[] args)
        {
            Console.WriteLine(MPlayer.record);
            Console.WriteLine((int)MPlayer.play);
        }
    }
}