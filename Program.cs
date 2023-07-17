class Player
{
    public string Name;
    public int fst;
    public int snd;
    public bool pair=false;//rank 1
    bool tpair=false;//rank 2
    bool toak=false;//rank 3
    bool str=false;//rank 4
    bool flush=false;//rank 5
    bool fhouse=false;//rank 6
    bool foak=false;//rank 7
    bool stflush=false;//rank 8
    bool royal=false;//rank 9
    public int rank=0;

}

class Program 
{
    static void Main ()
    {
        Player player1 = new Player();
        player1.Name= "player1";
        Player player2 = new Player();
        player2.Name= "player2";

        int[,] cards = new int [,]
        {
            {   0,1,2,3,4,5,6,7,8,9,10,11,12,
                13,14,15,16,17,18,19,20,21,22,23,24,25,
                26,27,28,29,30,31,32,33,34,35,36,37,38,
                39,40,41,42,43,44,45,46,47,48,49,50,51
            },
            {   2,3,4,5,6,7,8,9,10,11,12,13,14,
                2,3,4,5,6,7,8,9,10,11,12,13,14,
                2,3,4,5,6,7,8,9,10,11,12,13,14,
                2,3,4,5,6,7,8,9,10,11,12,13,14
            },
            {   0,0,0,0,0,0,0,0,0,0,0,0,0,
                1,1,1,1,1,1,1,1,1,1,1,1,1, 
                2,2,2,2,2,2,2,2,2,2,2,2,2, 
                3,3,3,3,3,3,3,3,3,3,3,3,3
            },
        };
/*
        Random random = new Random();
        int[] numerosSorteados = new int[17];
        int count = 0;

        while (count < 17)
        {
            int numeroSorteado = random.Next(0, 51);

            if (Array.IndexOf(numerosSorteados, numeroSorteado) == -1)
            {
                numerosSorteados[count] = numeroSorteado;
                count++;
            }
        }

    RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        int[] numerosSorteados = new int[9];
        int count = 0;

        while (count < 9)
        {
            byte[] randomBytes = new byte[4];
            rngCsp.GetBytes(randomBytes);
            int numeroSorteado = Math.Abs(BitConverter.ToInt32(randomBytes, 0)) % 52;

            if (Array.IndexOf(numerosSorteados, numeroSorteado) == -1)
            {
                numerosSorteados[count] = numeroSorteado;
                count++;
            }
        }

        

        Console.WriteLine("Números sorteados:");

        for (int i = 0; i < numerosSorteados.Length; i++)
        {
            Console.WriteLine(numerosSorteados[i]);
        }

*/
/*ids[0]=cards[1,table[0]];
                ids[1]=cards[1,table[1]];
                ids[2]=cards[1,table[2]];
                ids[3]=cards[1,table[3]];
                ids[4]=cards[1,table[4]];*/

        Random random = new Random();
        int[] numerosSorteados = new int[9];
        int count = 0;

        while (count < 9)
        {
            int numeroSorteado = random.Next(0, 51);

            if (Array.IndexOf(numerosSorteados, numeroSorteado) == -1)
            {
                numerosSorteados[count] = numeroSorteado;
                count++;
            }
        }
        


        int deckIndex=0;
        int[] table={numerosSorteados[0],numerosSorteados[1],numerosSorteados[2],numerosSorteados[3],numerosSorteados[4]};
        deckIndex=5;
        player1.fst=numerosSorteados[deckIndex];deckIndex++;
        player1.snd=numerosSorteados[deckIndex];deckIndex++;
        player2.fst=numerosSorteados[deckIndex];deckIndex++;
        player2.snd=numerosSorteados[deckIndex];deckIndex++;
        
        //int[] player1={numerosSorteados[deckIndex],numerosSorteados[deckIndex+1]};deckIndex+=2;
        //int[] player2={numerosSorteados[deckIndex],numerosSorteados[deckIndex+1]};deckIndex+=2;







        void SayCard (int fst,int snd,bool isTable)
        { 
            
            int[] ids= new int [2];
            string phrase="";
            if(isTable)
            {
                Array.Resize(ref ids, 5);
                
                ids[0]=table[0];
                ids[1]=table[1];
                ids[2]=table[2];
                ids[3]=table[3];
                ids[4]=table[4];
            }
            else
            {
                
                ids[0]= fst;
                ids[1]=snd;
                


                
            }
            

            foreach(int dcard in ids)
            {   
                switch (cards[1,dcard])
                {
                    case 2:
                    phrase = "Two";
                    break;

                    case 3:
                    phrase = "Three";
                    break;

                    case 4:
                    phrase = "Four";
                    break;

                    case 5:
                    phrase = "Five";
                    break;

                    case 6:
                    phrase = "Six";
                    break;

                    case 7:
                    phrase = "Seven";
                    break;

                    case 8:
                    phrase = "Eight";
                    break;

                    case 9:
                    phrase = "Nine";
                    break;

                    case 10:
                    phrase = "Ten";
                    break;

                    case 11:
                    phrase = "Jack";
                    break;

                    case 12:
                    phrase = "Queen";
                    break;

                    case 13:
                    phrase = "King";
                    break;

                    case 14:
                    phrase = "Ace";
                    break;
                }
            
                switch (cards[2,dcard]) 
                {
                    case 0:
                    phrase+=" of Clubs";
                    break;

                    case 1:
                    phrase+=" of Diamonds";
                    break;
                    
                    case 2:
                    phrase+=" of Hearts ♥";
                    break;

                    case 3:
                    phrase+=" of Spades";
                    break;
                }

                Console.WriteLine(phrase);
            }
        }
        Console.WriteLine("Table Cards: ------------------------------------");
        SayCard(0,0,true);
        Console.WriteLine("Player 1: ---------------------------------------" );
        SayCard(player1.fst,player1.snd,false);
        Console.WriteLine("Player 2: ---------------------------------------");
        SayCard(player2.fst,player2.snd,false);

    void LetsRank (int pa,int pb, string pname) 
    {
        int p1a=cards[1,pa];
        int p1b=cards[1,pb];
        int incRank=0;
        //player 1 ranking
                
        if (p1a==cards[1,table[0]]) 
        {
            incRank++;
        }
        else if (p1a==cards[1,table[1]])
        {
            incRank++;
        } 
        else if (p1a==cards[1,table[2]])
        {
            incRank++;
        } 
        else if (p1a==cards[1,table[3]])
        {
            incRank++;
        } 
        else if (p1a==cards[1,table[4]])
        {
            incRank++;
        } 
        
    
    
            if (p1b==cards[1,table[0]]) 
        {
            incRank++;
        }
        else if (p1b==cards[1,table[1]])
        {
            incRank++;
        } 
        else if (p1b==cards[1,table[2]])
        {
            incRank++;
        } 
        else if (p1b==cards[1,table[3]])
        {
            incRank++;
        } 
        else if (p1b==cards[1,table[4]])
        {
            incRank++;
        }
        else if (p1b==p1a)
        {
            incRank++;
        }
        //setting the ranking to the player
        if (pname=="player1")
        {
            player1.rank=incRank;
        }
        else
        {
            player2.rank=incRank;
        }

        
    }
    
    void Result () 
    {
        if (player1.rank>player2.rank)
        {
            //p1 wins
            Console.WriteLine($"Player 1 wins!");
        }
        else if (player1.rank==player2.rank)
        {
            //draw
            Console.WriteLine($"Draw!!!");
        }
        else if (player1.rank<player2.rank)
        {
            //p2 wins
            Console.WriteLine($"Player 2 wins!");
        }
    }
    
    LetsRank(player1.fst,player1.snd,player1.Name);
    LetsRank(player2.fst,player2.snd,player2.Name);
    Result();
    Console.WriteLine($"Rank p1:{player1.rank} Rank p2:{player2.rank}");

    
    

    }
}
