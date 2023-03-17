using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaSimplesmenteEncadeada
{
    internal class ListaSimplesmenteEncadeada
    {
        public Item Begin { get; set; }
        public Item End { get; set; }

        public ListaSimplesmenteEncadeada()
        {
            this.Begin = null;
            this.End = null;
        }

        public void Push(Item item)
        {
            if (IsEmpty())
            {
                Begin = item;
                End = item;
            }
            else
            {
                if (item.Value <= Begin.Value)
                {
                    InsertFirst(item);
                }
                else
                {
                    if (item.Value >= End.Value)
                    {
                        InsertEnd(item);
                    }
                    else
                    {
                        InsertMiddle(item);
                    }
                }
            }
        }

        public void InsertFirst(Item item)
        {
            item.NextValue = Begin;
            Begin = item;
        }

        public void InsertMiddle(Item item)
        {
            Item aux1 = Begin;
            Item aux2 = Begin.NextValue;

            while (aux2 != null)
            {
                if (item.Value < aux2.Value)
                {
                    item.NextValue = aux2;
                    aux1.NextValue = item;
                    return;
                }

                aux1 = aux2;
                aux2 = aux2.NextValue;
            }
        }

        public void InsertEnd(Item item)
        {
            End.NextValue = item;
            End = item;
        }


        public void Pop()
        {

        }

        public Item Find(Item f)
        {
            Item aux = Begin;
            while (aux != null)
            {
                if (aux.Value == f.Value)
                {
                    return aux;
                }
                else
                {
                    aux = aux.NextValue;
                }

            }

            aux = null;
            return aux;
        }

        public bool IsEmpty()
        {
            if (Begin == null)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {

            if (IsEmpty())
            {
                Console.WriteLine("Impossível imprimir lista vazia!");
                return;
            }
            Item aux = Begin;


            Console.WriteLine("Os elementos na pilha são: \n");

            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.NextValue;
            } while (aux != null);

            Console.WriteLine("Final da pilha");

        }


    }
}
