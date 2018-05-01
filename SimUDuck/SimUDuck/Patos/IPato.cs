using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    public interface IPato
    {

        void Grasnar();
        void Voar();
        void Nadar();
        void Nadar(string nome);
    }
}
