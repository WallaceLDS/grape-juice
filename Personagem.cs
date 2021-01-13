using System;

namespace grapeJuice
{    
    //CLASS Personagem
    public class Personagem
    {
            //attributes
            int _hp;
            int _atk;
            int _def;
            int _evs;

            //CONSTRUCT
            public Personagem(){
            _hp = 0;
            _atk = 0;
            _def = 0;
            _evs= 0;
            }

            //GET
            public int GEThp(){
                return _hp;            
            }
            public int GETatk(){
                return _atk;            
            }
            public int GETdef(){
                return _def;            
            }
            public int GETevs(){
                return _evs;            
            }

                


        
    }
}