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
    public int hPair=0;

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
            //this is the id of each card
            {   0,1,2,3,4,5,6,7,8,9,10,11,12,
                13,14,15,16,17,18,19,20,21,22,23,24,25,
                26,27,28,29,30,31,32,33,34,35,36,37,38,
                39,40,41,42,43,44,45,46,47,48,49,50,51
            },
            //this is the value of the cards
            {   2,3,4,5,6,7,8,9,10,11,12,13,14,
                2,3,4,5,6,7,8,9,10,11,12,13,14,
                2,3,4,5,6,7,8,9,10,11,12,13,14,
                2,3,4,5,6,7,8,9,10,11,12,13,14
            },
            //this is the suits 0-clubs 1-diamonds 2-hearts 3-spades
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
                    phrase = "2";
                    break;

                    case 3:
                    phrase = "3";
                    break;

                    case 4:
                    phrase = "4";
                    break;

                    case 5:
                    phrase = "5";
                    break;

                    case 6:
                    phrase = "6";
                    break;

                    case 7:
                    phrase = "7";
                    break;

                    case 8:
                    phrase = "8";
                    break;

                    case 9:
                    phrase = "9";
                    break;

                    case 10:
                    phrase = "T";
                    break;

                    case 11:
                    phrase = "J";
                    break;

                    case 12:
                    phrase = "Q";
                    break;

                    case 13:
                    phrase = "K";
                    break;

                    case 14:
                    phrase = "A";
                    break;
                }
            
                switch (cards[2,dcard]) 
                {
                    case 0:
                    phrase+=" ♣";
                    break;

                    case 1:
                    phrase+=" ♦";
                    break;
                    
                    case 2:
                    phrase+=" ♥";
                    break;

                    case 3:
                    phrase+=" ♠";
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
        int highPair=0;
        //player 1 ranking
                
        if (p1a==cards[1,table[0]]) 
        {
            incRank++;
            if (p1a>highPair){highPair=p1a;}
        }
        else if (p1a==cards[1,table[1]])
        {
            incRank++;
            if (p1a>highPair){highPair=p1a;}
        } 
        else if (p1a==cards[1,table[2]])
        {
            incRank++;
            if (p1a>highPair){highPair=p1a;}
        } 
        else if (p1a==cards[1,table[3]])
        {
            incRank++;
            if (p1a>highPair){highPair=p1a;}
        } 
        else if (p1a==cards[1,table[4]])
        {
            incRank++;
            if (p1a>highPair){highPair=p1a;}
        } 
        
    
    
            if (p1b==cards[1,table[0]]) 
        {
            incRank++;
            if (p1b>highPair){highPair=p1b;}
        }
        else if (p1b==cards[1,table[1]])
        {
            incRank++;
            if (p1b>highPair){highPair=p1b;}
        } 
        else if (p1b==cards[1,table[2]])
        {
            incRank++;
            if (p1b>highPair){highPair=p1b;}
        } 
        else if (p1b==cards[1,table[3]])
        {
            incRank++;
            if (p1b>highPair){highPair=p1b;}
        } 
        else if (p1b==cards[1,table[4]])
        {
            incRank++;
            if (p1b>highPair){highPair=p1b;}
        }
        else if (p1b==p1a)
        {
            incRank++;
            if (p1b>highPair){highPair=p1b;}
        }
        //setting the ranking to the player
        if (pname=="player1")
        {
            player1.rank=incRank;
            player1.hPair=highPair;
        }
        else
        {
            player2.rank=incRank;
            player2.hPair=highPair;
        }

        
    }
    
    void Result () 
    {
        if (player1.rank>player2.rank)
        {
            //p1 wins
            string adjust=player1.hPair.ToString();
            switch(adjust)
            {
                case "11":
                adjust="Jacks";
                break;
                case "12":
                adjust="Queens";
                break;
                case "13":
                adjust="Kings";
                break;
                case "14":
                adjust="Aces";
                break;
            }
            Console.WriteLine($"Player 1 wins with a pair of {adjust}");
        }
        else if (player1.rank==player2.rank)
        {
            if(player1.hPair>player2.hPair)
            {
                string adjust=player1.hPair.ToString();
            switch(adjust)
            {
                case "11":
                adjust="Jacks";
                break;
                case "12":
                adjust="Queens";
                break;
                case "13":
                adjust="Kings";
                break;
                case "14":
                adjust="Aces";
                break;
            }
                Console.WriteLine($"Player 1 wins with a pair of {adjust}");
            }
            else if(player2.hPair>player1.hPair)
            {
                string adjust=player2.hPair.ToString();
            switch(adjust)
            {
                case "11":
                adjust="Jacks";
                break;
                case "12":
                adjust="Queens";
                break;
                case "13":
                adjust="Kings";
                break;
                case "14":
                adjust="Aces";
                break;
            }
                Console.WriteLine($"Player 2 wins with a pair of {adjust}!");
            }
            else if (player2.hPair==player2.hPair)
            {
                Console.WriteLine($"DRAW!");
            }
        }
        else if (player1.rank<player2.rank)
        {
            //p2 wins
            string adjust=player2.hPair.ToString();
            switch(adjust)
            {
                case "11":
                adjust="Jacks";
                break;
                case "12":
                adjust="Queens";
                break;
                case "13":
                adjust="Kings";
                break;
                case "14":
                adjust="Aces";
                break;
            }
            Console.WriteLine($"Player 2 wins with a pair of {adjust}");
        }
    }
    
    LetsRank(player1.fst,player1.snd,player1.Name);
    LetsRank(player2.fst,player2.snd,player2.Name);
    Result();
    Console.WriteLine($"Rank p1:{player1.rank} Rank p2:{player2.rank}");

    
    

    }
}
