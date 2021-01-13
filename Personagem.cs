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
            public Personagem(int hp, int atk, int def, int evs){
            _hp = hp;
            _atk = atk;
            _def = def;
            _evs= evs;
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