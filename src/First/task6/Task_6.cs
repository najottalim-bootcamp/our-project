namespace First.task6
{
    public class Task_6
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("Nimgapalar???");
        }
    }
}
