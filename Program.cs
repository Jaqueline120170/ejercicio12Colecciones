namespace ejercicio2Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clientes = new Queue<string>();
            clientes.Enqueue("Cliente 1");
            clientes.Enqueue("Cliente 2");
            clientes.Enqueue("Cliente 3");
            clientes.Enqueue("Cliente 4");
            clientes.Enqueue("Cliente 5");
            clientes.Enqueue("Cliente 6");
            clientes.Enqueue("Cliente 7");


            foreach(string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
            Console.WriteLine("Nuevo primer elemento de la cola: " + clientes.Peek());

            while (clientes.Count > 0)
            {
                string clienteActual = clientes.Dequeue();
                Console.WriteLine("Atendiendo a: " + clienteActual);
                
            }
        }
    }
}
