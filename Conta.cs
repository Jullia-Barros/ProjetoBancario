 using System;
 using System.Collections Generic;
 using System.Linq;
 using System.text;
 using System.Threading.Tasks;

 namespace ProjetoBancario
 {
     internal class Conta
 {
     public double saldo;
     public int numero;

     public void Depositar (double valor)
     {
        if (valor>0)
        {
            saldo += valor;
        }
     }
     public boolean Sacar (double valor)
     {
         if (valor >0 && valor<=saldo)
         {
             saldo -=valor;
             return true;
         }
             return false;
     }
        public String ConsultarSaldo()
        {
            return saldo.toString();
        }

        public void Transferir (double valor, Conta destino)
         {
             if (valor>0 && Sacar (valor))
             {
                 destino.Depositar(valor);
             }
         }
    
    }
   }
 }

 
     
 