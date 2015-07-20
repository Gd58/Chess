using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace chess
{

    #region
    public partial class _Default : System.Web.UI.Page
    {
        #region
      
        static int Which_player = 1;  


        static int[] hasPlayedOfPlayer1 = new int[10]{0,0,0,0,0,0,0,0,0,0};

        


        static int[] hasPlayedOfPlayer2 = new int[10]{0,0,0,0,0,0,0,0,0,0};


        static int theTimeOfPlayer1 = 0;
        static int theTimeOfPlayer2 = 0;

      


        Color player1Color = Color.FromArgb(100, 255, 0, 0);
        Color player2Color = Color.FromArgb(100, 0, 255, 0);
        Color SystemColor = Color.FromArgb(100, 255, 255, 255);


        static int win = 0;

       
        static int[] curButtonNumber = new int[100]; //Stack of Button


        static int indexCurButtonNumber = 1;


        static int index_1 =  0;


        protected void Page_Load(object sender, EventArgs e)
        {

                    Lbel1.Visible = false;
                    Lbel2.Visible = false;
                    Label3.Visible = false;

                    Label4.Visible = false;
        }

        public bool player1CurWinState()
        {
            bool first_State = false;
            bool second_State = false;
            bool three_State = false;
            bool four_State = false;
            for (int _ty = 0; _ty < 3; ++_ty)
            {

                if (hasPlayedOfPlayer1[1 + _ty * 3] == 1
                    && hasPlayedOfPlayer1[2 + _ty * 3] == 1
                    && hasPlayedOfPlayer1[3 + _ty * 3] == 1)
                         {

                                first_State = true;
                                break;

                         }
                    else if (hasPlayedOfPlayer1[_ty + 1] == 1
                              && hasPlayedOfPlayer1[_ty + 4] == 1
                              && hasPlayedOfPlayer1[_ty + 7] == 1)
                                {

                                    second_State = true;
                                    break;
                                }
            }
            if (hasPlayedOfPlayer1[1] == 1
                && hasPlayedOfPlayer1[5] == 1
                && hasPlayedOfPlayer1[9] == 1)
                    {
                        three_State = true;
                    }
                else if (hasPlayedOfPlayer1[3] == 1
                    && hasPlayedOfPlayer1[5] == 1
                    && hasPlayedOfPlayer1[7] == 1)
                        {

                            four_State = true;
                        }
            return (first_State || second_State || three_State || four_State);
        }

        public bool player2CurWinState()
        {
            bool first_State = false;
            bool second_State = false;
            bool three_State = false;
            bool four_State = false;
            for (int _ty = 0; _ty < 3; ++_ty)
            {

                if (hasPlayedOfPlayer2[1 + _ty * 3] == 1
                    && hasPlayedOfPlayer2[2 + _ty * 3] == 1
                    && hasPlayedOfPlayer2[3 + _ty * 3] == 1)
                    {

                        first_State = true;
                        break;

                    }
                else if (hasPlayedOfPlayer2[_ty + 1] == 1
                          && hasPlayedOfPlayer2[_ty + 4] == 1
                              && hasPlayedOfPlayer2[_ty + 7] == 1)
                     {

                        first_State = true;
                         break;
                     }
            }
            if (hasPlayedOfPlayer2[1] == 1
                     && hasPlayedOfPlayer2[5] == 1
                         && hasPlayedOfPlayer2[9] == 1)
                    {
                        three_State = true;
                    }
            else if (hasPlayedOfPlayer2[3] == 1
                && hasPlayedOfPlayer2[5] == 1
                && hasPlayedOfPlayer2[7] == 1)
            {

                four_State = true;
            }
            return (first_State || second_State || three_State || four_State);

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            int curValue = Convert.ToInt16(btn1.Text);

            if (win==0)
            {
                if (hasPlayedOfPlayer1[curValue] == 1 || hasPlayedOfPlayer2[curValue] == 1)
                {
                    Label3.Visible = true;
                    return;
                }
                if (Which_player == 1)
                {



                    theTimeOfPlayer1++; //the times of the player play
                    hasPlayedOfPlayer1[curValue] = 1; //deal to the player to player
                    btn1.BackColor = player1Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer1 >= 3)
                    {
                        if (player1CurWinState())
                        {
                            Lbel1.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 2;
                }
                else
                {

                    theTimeOfPlayer2++; //the times of the player play
                    hasPlayedOfPlayer2[curValue] = 1; //deal to the player to player
                    btn1.BackColor = player2Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer2 >= 3)
                    {
                        if (player2CurWinState())
                        {
                            Lbel2.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 1;
                }
            }
            else
            {
                Label3.Visible = true;
                return;
            }
            if (index_1==1)
            {
                RebotPlayer1();
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            int curValue = Convert.ToInt16(btn2.Text);
            if (win==0)
            {
                if (hasPlayedOfPlayer1[curValue] == 1 || hasPlayedOfPlayer2[curValue] == 1)
                {
                    Label3.Visible = true;
                    return;
                }
                if (Which_player == 1)
                {
                    theTimeOfPlayer1++; //the times of the player play
                    hasPlayedOfPlayer1[curValue] = 1; //deal to the player to player
                    btn2.BackColor = player1Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer1 >= 3)
                    {
                        if (player1CurWinState())
                        {
                            Lbel1.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 2;
                }
                else
                {
                    theTimeOfPlayer2++; //the times of the player play
                    hasPlayedOfPlayer2[curValue] = 1; //deal to the player to player
                    btn2.BackColor = player2Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer2 >= 3)
                    {
                        if (player2CurWinState())
                        {
                            Lbel2.Visible = true;
                            win = 1;
                        }

                    }
                    Which_player = 1;
                }
            }
            else
            {
                Label3.Visible = true;
                return;
            }
            if (index_1==1)
            {
                RebotPlayer1();
            }

        }


        protected void btn3_Click(object sender, EventArgs e)
        {
            int curValue = Convert.ToInt16(btn3.Text);

            if (0==win)
            {
                if (hasPlayedOfPlayer1[curValue] == 1 || hasPlayedOfPlayer2[curValue] == 1)
                {
                    Label3.Visible = true;
                    return;
                }
                if (Which_player == 1)
                {



                    theTimeOfPlayer1++; //the times of the player play
                    hasPlayedOfPlayer1[curValue] = 1; //deal to the player to player
                    btn3.BackColor = player1Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer1 >= 3)
                    {
                        if (player1CurWinState())
                        {
                            Lbel1.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 2;
                }
                else
                {

                    theTimeOfPlayer2++; //the times of the player play
                    hasPlayedOfPlayer2[curValue] = 1; //deal to the player to player
                    btn3.BackColor = player2Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer2 >= 3)
                    {
                        if (player2CurWinState())
                        {
                            Lbel2.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 1;
                }
            }
            else
            {
                Label3.Visible = true;
                return;
            }
            if (index_1==1)
            {
                RebotPlayer1();
            }

        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            int curValue = Convert.ToInt16(btn4.Text);

            if (0==win)
            {
                if (hasPlayedOfPlayer1[curValue] == 1 || hasPlayedOfPlayer2[curValue] == 1)
                {
                    Label3.Visible = true;
                    return;
                }
                if (Which_player == 1)
                {



                    theTimeOfPlayer1++; //the times of the player play
                    hasPlayedOfPlayer1[curValue] = 1; //deal to the player to player
                    btn4.BackColor = player1Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer1 >= 3)
                    {
                        if (player1CurWinState())
                        {
                            Lbel1.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 2;
                }
                else
                {

                    theTimeOfPlayer2++; //the times of the player play
                    hasPlayedOfPlayer2[curValue] = 1; //deal to the player to player
                    btn4.BackColor = player2Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer2 >= 3)
                    {
                        if (player2CurWinState())
                        {
                            Lbel2.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 1;
                }

            }
            else
            {
                Label3.Visible = true;
                return;
            }
            if (index_1==1)
            {
                RebotPlayer1();
            }
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            int curValue = Convert.ToInt16(btn5.Text);

            if (0==win)
            {
                if (hasPlayedOfPlayer1[curValue] == 1 || hasPlayedOfPlayer2[curValue] == 1)
                {
                    Label3.Visible = true;
                    return;
                }
                if (Which_player == 1)
                {



                    theTimeOfPlayer1++; //the times of the player play
                    hasPlayedOfPlayer1[curValue] = 1; //deal to the player to player
                    btn5.BackColor = player1Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer1 >= 3)
                    {
                        if (player1CurWinState())
                        {
                            Lbel1.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 2;
                }
                else
                {
                    theTimeOfPlayer2++; //the times of the player play
                    hasPlayedOfPlayer2[curValue] = 1; //deal to the player to player
                    btn5.BackColor = player2Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer2 >= 3)
                    {
                        if (player2CurWinState())
                        {
                            Lbel2.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 1;
                }

            }
            else
            {
                Label3.Visible = true;
                return;
            }
            if (index_1==1)
            {
                RebotPlayer1();
            }
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            int curValue = Convert.ToInt16(btn6.Text);

            if (0==win)
            {
                if (hasPlayedOfPlayer1[curValue] == 1 || hasPlayedOfPlayer2[curValue] == 1)
                {
                    Label3.Visible = true;
                    return;
                }
                if (Which_player == 1)
                {



                    theTimeOfPlayer1++; //the times of the player play
                    hasPlayedOfPlayer1[curValue] = 1; //deal to the player to player

                    btn6.BackColor = player1Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer1 >= 3)
                    {
                        if (player1CurWinState())
                        {
                            Lbel1.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 2;
                }
                else
                {

                    theTimeOfPlayer2++; //the times of the player play
                    hasPlayedOfPlayer2[curValue] = 1; //deal to the player to player
                    btn6.BackColor = player2Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer2 >= 3)
                    {
                        if (player2CurWinState())
                        {
                            Lbel2.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 1;
                }
            }
            else
            {
                Label3.Visible = true;
                return;
            }
            if (index_1==1)
            {
                RebotPlayer1();
            }
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            int curValue = Convert.ToInt16(btn7.Text);

            if (0==win)
            {
                if (hasPlayedOfPlayer1[curValue] == 1 || hasPlayedOfPlayer2[curValue] == 1)
                {
                    Label3.Visible = true;
                    return;
                }
                if (Which_player == 1)
                {



                    theTimeOfPlayer1++; //the times of the player play
                    hasPlayedOfPlayer1[curValue] = 1; //deal to the player to player
                    btn7.BackColor = player1Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer1 >= 3)
                    {
                        if (player1CurWinState())
                        {
                            Lbel1.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 2;
                }
                else
                {

                    theTimeOfPlayer2++; //the times of the player play
                    hasPlayedOfPlayer2[curValue] = 1; //deal to the player to player
                    btn7.BackColor = player2Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer2 >= 3)
                    {
                        if (player2CurWinState())
                        {
                            Lbel2.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 1;
                }

            }
            else
            {
                Label3.Visible = true;
                return;
            }
            if (index_1==1)
            {
                RebotPlayer1();
            }
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            int curValue = Convert.ToInt16(btn8.Text);

            if (0==win)
            {
                if (hasPlayedOfPlayer1[curValue] == 1 || hasPlayedOfPlayer2[curValue] == 1)
                {
                    Label3.Visible = true;
                    return;
                }
                if (Which_player == 1)
                {



                    theTimeOfPlayer1++; //the times of the player play
                    hasPlayedOfPlayer1[curValue] = 1; //deal to the player to player
                    btn8.BackColor = player1Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer1 >= 3)
                    {
                        if (player1CurWinState())
                        {
                            Lbel1.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 2;
                }
                else
                {

                    theTimeOfPlayer2++; //the times of the player play
                    hasPlayedOfPlayer2[curValue] = 1; //deal to the player to player
                    btn8.BackColor = player2Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer2 >= 3)
                    {
                        if (player2CurWinState())
                        {
                            Lbel2.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 1;
                }

            }
            else
            {
                Label3.Visible = true;
                return;
            }
            if (index_1==1)
            {
                RebotPlayer1();
            }
        }

        protected void btn9_Click(object sender, EventArgs e)
        {

            int curValue = Convert.ToInt16(btn9.Text);

            if (0==win)
            {
                if (hasPlayedOfPlayer1[curValue] == 1 || hasPlayedOfPlayer2[curValue] == 1)
                {
                    Label3.Visible = true;
                    return;
                }
                if (Which_player == 1)
                {



                    theTimeOfPlayer1++; //the times of the player play
                    hasPlayedOfPlayer1[curValue] = 1; //deal to the player to player
                    btn9.BackColor = player1Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer1 >= 3)
                    {
                        if (player1CurWinState())
                        {
                            Lbel1.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 2;
                }
                else
                {
                    theTimeOfPlayer2++; //the times of the player play
                    hasPlayedOfPlayer2[curValue] = 1; //deal to the player to player
                    btn9.BackColor = player2Color;   //deal to make backgroundcolor
                    curButtonNumber[indexCurButtonNumber++] = curValue;
                    if (theTimeOfPlayer2 >= 3)
                    {
                        if (player2CurWinState())
                        {
                            Lbel2.Visible = true;
                            win = 1;
                        }
                    }
                    Which_player = 1;
                }

            }

            else
            {
                Label3.Visible = true;
                return;
            }
            if (index_1==1)
            {
                RebotPlayer1();
            }

        }
        #endregion
        #region
        

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("Default.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Help.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (indexCurButtonNumber != 1)
            {
                if (Which_player == 1)
                {
                    hasPlayedOfPlayer2[curButtonNumber[indexCurButtonNumber - 1]] = 0;
                    --theTimeOfPlayer2;

                    Which_player = 2;
                }

                else
                {
                    hasPlayedOfPlayer1[curButtonNumber[indexCurButtonNumber - 1]] = 0;

                    --theTimeOfPlayer1;

                    Which_player = 1;

                }

                switch (curButtonNumber[indexCurButtonNumber - 1])
                {
                    case 1: btn1.BackColor = SystemColor; break;
                    case 2: btn2.BackColor = SystemColor; break;
                    case 3: btn3.BackColor = SystemColor; break;
                    case 4: btn4.BackColor = SystemColor; break;
                    case 5: btn5.BackColor = SystemColor; break;

                    case 6: btn6.BackColor = SystemColor; break;
                    case 7: btn7.BackColor = SystemColor; break;
                    case 8: btn8.BackColor = SystemColor; break;
                    default: btn9.BackColor = SystemColor; break;


                }
                --indexCurButtonNumber;
            }
            else
            {
                return;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // this is a  some the maker;
            //      you can mail to them 
            //
            //
            //
            Response.Redirect("AboutMaker.aspx");
        }
        #endregion
        protected void Btn1_Click(object sender, EventArgs e) //RebotPlayer1
        {       
            index_1 = 1;
            RebotPlayer1();
           
        }
        //RebotPlayer1
    #endregion
        public void RebotPlayer1()
        {
            int WayofPlayer2Win = WhetherPlayer2HasLinkingOfTwo();
            int WayofPlayer1Win = WhetherPlayer1HasLinkingOfTwo();
            #region
            bool Continue_1 = false;
            if (Which_player != 1)
            {
                Label3.Visible = true;
                return;
            }
#endregion
            #region
            if (0==win)
            {
                if (theTimeOfPlayer2 >= 2)//deal with theTimeOfPlayer2>=2
                {
                    if (WayofPlayer2Win != 0)   //wheather linking of Player
                    {
                        if (hasPlayedOfPlayer1[WayofPlayer2Win] != 1)
                        {
                            #region
                            Continue_1 = true;
                            switch (WayofPlayer2Win)
                            {

                                /*  get the smart btn_Click; and int btnClickNum = btn_Click;
                                 * First to search the completer 
              

             
             
                                 */

                                case 1:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[1] = 1; //deal to the player to player
                                        btn1.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 1;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                        
                                    }
                                    break;


                                case 2:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[2] = 1; //deal to the player to player
                                        btn2.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 2;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 3:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[3] = 1; //deal to the player to player
                                        btn3.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 3;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 4:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[4] = 1; //deal to the player to player
                                        btn4.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 4;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 5:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[5] = 1; //deal to the player to player
                                        btn5.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 5;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;

                                case 6:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[6] = 1; //deal to the player to player
                                        btn6.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 6;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 7:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[7] = 1; //deal to the player to player
                                        btn7.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 7;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 8:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[8] = 1; //deal to the player to player
                                        btn8.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 8;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 9:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[9] = 1; //deal to the player to player
                                        btn9.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 9;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;

                            }
                            #endregion
                        }
                    }
                }
            #endregion         //theTimeOfPlayer2>=2
            }
            if (Continue_1)
                return;
           
            if (0==win)
            {
                 #region
                bool Continue = false;
                if (theTimeOfPlayer1 >= 2)  //check times of the player1
                {
                    if (WayofPlayer1Win != 0)  //check Whether the Linkiing player1
                    {

                        if (hasPlayedOfPlayer2[WayofPlayer1Win] != 1)
                        #region
                        {

                            Continue = true;
                            #region
                            switch (WayofPlayer1Win)
                            {

                                /*  get the smart btn_Click; and int btnClickNum = btn_Click;
                                 * First to search the completer 
              

             
             
                                 */

                                case 1:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[1] = 1; //deal to the player to player
                                        btn1.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 1;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;


                                case 2:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[2] = 1; //deal to the player to player
                                        btn2.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 2;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 3:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[3] = 1; //deal to the player to player
                                        btn3.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 3;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 4:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[4] = 1; //deal to the player to player
                                        btn4.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 4;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 5:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[5] = 1; //deal to the player to player
                                        btn5.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 5;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;

                                case 6:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[6] = 1; //deal to the player to player
                                        btn6.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 6;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;


                                    }

                                    break;
                                case 7:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[7] = 1; //deal to the player to player
                                        btn7.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 7;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 8:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[8] = 1; //deal to the player to player
                                        btn8.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 8;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;
                                case 9:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[9] = 1; //deal to the player to player
                                        btn9.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 9;
                                        if (theTimeOfPlayer1 >= 3)
                                        {
                                            if (player1CurWinState())
                                            {
                                                Lbel1.Visible = true;
                                                win = 1;
                                            }
                                        }
                                        Which_player = 2;
                                    }
                                    break;

                            }
                            #endregion
                        }
                        #endregion
                        else if (hasPlayedOfPlayer2[WayofPlayer1Win] == 1) //player1 linking 2 was blocked by player2
                        {
                            if (Withplayer1_1andNoplayer2() != 0) //Player1 2Times and not Blocked by Player2
                            {
#region                         
                                int _index = Withplayer1_1andNoplayer2();
                                Continue = true;
              #region
                                switch (_index)
                                {

                                    /*  get the smart btn_Click; and int btnClickNum = btn_Click;
                                     * First to search the completer 
              

             
             
                                     */

                                    case 1:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[1] = 1; //deal to the player to player
                                            btn1.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 1;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;


                                    case 2:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[2] = 1; //deal to the player to player
                                            btn2.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 2;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;
                                    case 3:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[3] = 1; //deal to the player to player
                                            btn3.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 3;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;
                                    case 4:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[4] = 1; //deal to the player to player
                                            btn4.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 4;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;
                                    case 5:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[5] = 1; //deal to the player to player
                                            btn5.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 5;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;

                                    case 6:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[6] = 1; //deal to the player to player
                                            btn6.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 6;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;


                                        }

                                        break;
                                    case 7:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[7] = 1; //deal to the player to player
                                            btn7.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 7;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;
                                    case 8:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[8] = 1; //deal to the player to player
                                            btn8.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 8;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;
                                   case 9:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[9] = 1; //deal to the player to player
                                            btn9.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 9;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;

                                }
              #endregion
#endregion

                            }
                            #region
                            else //Random a place
                            {

                                int CurPlayerPosition = RandomPlayer1Place();
                                Continue = true;
#region 
                                #region
                                switch (CurPlayerPosition)
                                {

                                    /*  get the smart btn_Click; and int btnClickNum = btn_Click;
                                     * First to search the completer 
              

             
             
                                     */

                                    case 1:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[1] = 1; //deal to the player to player
                                            btn1.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 1;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;


                                    case 2:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[2] = 1; //deal to the player to player
                                            btn2.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 2;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;
                                    case 3:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[3] = 1; //deal to the player to player
                                            btn3.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 3;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;
                                    case 4:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[4] = 1; //deal to the player to player
                                            btn4.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 4;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;
                                    case 5:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[5] = 1; //deal to the player to player
                                            btn5.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 5;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;

                                    case 6:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[6] = 1; //deal to the player to player
                                            btn6.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 6;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;


                                        }

                                        break;
                                    case 7:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[7] = 1; //deal to the player to player
                                            btn7.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 7;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;
                                    case 8:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[8] = 1; //deal to the player to player
                                            btn8.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 8;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;
                                   case 9:
                                        {
                                            theTimeOfPlayer1++; //the times of the player play
                                            hasPlayedOfPlayer1[9] = 1; //deal to the player to player
                                            btn9.BackColor = player1Color;   //deal to make backgroundcolor
                                            curButtonNumber[indexCurButtonNumber++] = 9;
                                            if (theTimeOfPlayer1 >= 3)
                                            {
                                                if (player1CurWinState())
                                                {
                                                    Lbel1.Visible = true;
                                                    win = 1;
                                                }
                                            }
                                            Which_player = 2;
                                        }
                                        break;

                                }
                                #endregion
#endregion

                            }
                            #endregion
                        }
                    }
                }
            #endregion
                if (Continue) return;
                #region
                if (theTimeOfPlayer1 == 1)
                {

                    if (Withplayer1_1andNoplayer2() != 0)
                    {
                        #region
                        int Position = Withplayer1_1andNoplayer2();
                        switch (Position)
                        {

                            /*  get the smart btn_Click; and int btnClickNum = btn_Click;
                             * First to search the completer 
              

             
             
                             */

                            case 1:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[1] = 1; //deal to the player to player
                                    btn1.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 1;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;


                            case 2:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[2] = 1; //deal to the player to player
                                    btn2.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 2;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;
                            case 3:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[3] = 1; //deal to the player to player
                                    btn3.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 3;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;
                            case 4:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[4] = 1; //deal to the player to player
                                    btn4.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 4;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;
                            case 5:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[5] = 1; //deal to the player to player
                                    btn5.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 5;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;

                            case 6:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[6] = 1; //deal to the player to player
                                    btn6.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 6;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;


                                }

                                break;
                            case 7:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[7] = 1; //deal to the player to player
                                    btn7.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 7;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;
                            case 8:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[8] = 1; //deal to the player to player
                                    btn8.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 8;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;
                            case 9:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[9] = 1; //deal to the player to player
                                    btn9.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 9;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;

                        }
                        #endregion

                    }
                    else //Random a place
                    {
                        int CurPlayerPosition = RandomPlayer1Place();
                        #region
                        #region
                        switch (CurPlayerPosition)
                        {

                            /*  get the smart btn_Click; and int btnClickNum = btn_Click;
                             * First to search the completer 
              

             
             
                             */

                            case 1:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[1] = 1; //deal to the player to player
                                    btn1.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 1;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;


                            case 2:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[2] = 1; //deal to the player to player
                                    btn2.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 2;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;
                            case 3:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[3] = 1; //deal to the player to player
                                    btn3.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 3;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;
                            case 4:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[4] = 1; //deal to the player to player
                                    btn4.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 4;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;
                            case 5:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[5] = 1; //deal to the player to player
                                    btn5.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 5;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;

                            case 6:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[6] = 1; //deal to the player to player
                                    btn6.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 6;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;


                                }

                                break;
                            case 7:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[7] = 1; //deal to the player to player
                                    btn7.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 7;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;
                            case 8:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[8] = 1; //deal to the player to player
                                    btn8.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 8;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;
                            case 9:
                                {
                                    theTimeOfPlayer1++; //the times of the player play
                                    hasPlayedOfPlayer1[9] = 1; //deal to the player to player
                                    btn9.BackColor = player1Color;   //deal to make backgroundcolor
                                    curButtonNumber[indexCurButtonNumber++] = 9;
                                    if (theTimeOfPlayer1 >= 3)
                                    {
                                        if (player1CurWinState())
                                        {
                                            Lbel1.Visible = true;
                                            win = 1;
                                        }
                                    }
                                    Which_player = 2;
                                }
                                break;

                        }
                        #endregion
                        #endregion

                    }


                }
                #endregion
                #region
                if (theTimeOfPlayer1 == 0)
                {
                    
                            #region
                    Random Rdom = new Random();
                    int __t = (int)(Rdom.Next() % 10);
                    while (__t == 0)
                    {
                            __t =(int) (Rdom.Next());
                        if(__t% 10 != 0)
                        {
                            break; 
                        }
                    }
                    
                    #region
                    switch (__t)
                            {

                                /*  get the smart btn_Click; and int btnClickNum = btn_Click;
                                 * First to search the completer 
              

             
             
                                 */

                                case 1:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[1] = 1; //deal to the player to player
                                        btn1.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 1;

                                        Which_player = 2;
                                    }
                                    break;


                                case 2:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[2] = 1; //deal to the player to player
                                        btn2.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 2;

                                        Which_player = 2;
                                    }
                                    break;
                                case 3:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[3] = 1; //deal to the player to player
                                        btn3.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 3;

                                        Which_player = 2;
                                    }
                                    break;
                                case 4:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[4] = 1; //deal to the player to player
                                        btn4.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 4;

                                        Which_player = 2;
                                    }
                                    break;
                                case 5:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[5] = 1; //deal to the player to player
                                        btn5.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 5;

                                        Which_player = 2;
                                    }
                                    break;

                                case 6:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[6] = 1; //deal to the player to player
                                        btn6.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 6;

                                        Which_player = 2;
                                    }
                                    break;
                                case 7:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[7] = 1; //deal to the player to player
                                        btn7.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 7;

                                        Which_player = 2;
                                    }
                                    break;
                                case 8:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[8] = 1; //deal to the player to player
                                        btn8.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 8;

                                        Which_player = 2;
                                    }
                                    break;
                                case 9:
                                    {
                                        theTimeOfPlayer1++; //the times of the player play
                                        hasPlayedOfPlayer1[9] = 1; //deal to the player to player
                                        btn9.BackColor = player1Color;   //deal to make backgroundcolor
                                        curButtonNumber[indexCurButtonNumber++] = 9;

                                        Which_player = 2;
                                    }
                                    break;

                            }

                            #endregion
                      

                }
                #endregion 
                #endregion//Playeyer1 == 0

                /*switch (btnClickNum)
        {

        } */
            }
        }
                

        public int WhetherPlayer2HasLinkingOfTwo()
        {
            int first_Count = 0;
            int second_Count = 0;
            int three_Count = 0;
            int four_Count = 0;
            for (int _ty = 0; _ty < 3; ++_ty)
            {

                if (hasPlayedOfPlayer2[1 + _ty * 3] == 0)

                    ++first_Count;
                if (hasPlayedOfPlayer2[2 + _ty * 3] == 0)

                    ++first_Count;
                if (hasPlayedOfPlayer2[3 + _ty * 3] == 0)
                    ++first_Count;

                if (first_Count == 1)
                {

                    if (hasPlayedOfPlayer2[1 + _ty * 3] == 0)

                        return _ty * 3 + 1;
                    if (hasPlayedOfPlayer2[2 + _ty * 3] == 0)

                        return _ty * 3 + 2;
                    if (hasPlayedOfPlayer2[3 + _ty * 3] == 0)
                        return _ty * 3 + 3;
                }
                else
                    first_Count = 0;


                if (hasPlayedOfPlayer2[_ty + 1] == 0)


                    ++second_Count;
                if (hasPlayedOfPlayer2[_ty + 4] == 0)

                    ++second_Count;
                if (hasPlayedOfPlayer2[_ty + 7] == 0)


                    ++second_Count;
                if (second_Count == 1)
                {

                    if (hasPlayedOfPlayer2[_ty + 1] == 0)

                        return _ty + 1;

                    if (hasPlayedOfPlayer2[_ty + 4] == 0)

                        return _ty + 4;
                    if (hasPlayedOfPlayer2[_ty + 7] == 0)
                        return _ty + 7;
                }
                else
                {
                    second_Count = 0;
                }
            }

            /////////////////////////////////////////////
            if (hasPlayedOfPlayer2[1] == 0)
                ++three_Count;

            if (hasPlayedOfPlayer2[5] == 0)
                ++three_Count;

            if (hasPlayedOfPlayer2[9] == 0)
                ++three_Count;

            if (three_Count == 1)
            {
                if (hasPlayedOfPlayer2[1] == 0)
                    return 1;

                if (hasPlayedOfPlayer2[5] == 0)
                    return 5;

                if (hasPlayedOfPlayer2[9] == 0)
                    return 9;
            }
            else
            {
                three_Count = 0;
            }
            if (hasPlayedOfPlayer2[3] == 0)
                ++four_Count;
            if (hasPlayedOfPlayer2[5] == 0)
                ++four_Count;
            if (hasPlayedOfPlayer2[7] == 0)
                ++four_Count;
            if (four_Count == 1)
            {
                if (hasPlayedOfPlayer2[3] == 0)
                    return 3;
                if (hasPlayedOfPlayer2[5] == 0)
                    return 5;
                if (hasPlayedOfPlayer2[7] == 0)
                    return 7;

            }
            else
            {
                four_Count = 0;
            }
            return 0;
        }

        public int WhetherPlayer1HasLinkingOfTwo()
        {
            int first_Count = 0;
            int second_Count = 0;
            int three_Count = 0;
            int four_Count = 0;
            for (int _ty = 0; _ty < 3; ++_ty)
            {

                if (hasPlayedOfPlayer1[1 + _ty * 3] == 0)

                        ++first_Count;
                if (hasPlayedOfPlayer1[2 + _ty * 3] == 0)

                         ++first_Count;
                if (hasPlayedOfPlayer1[3 + _ty * 3] == 0)
                         ++first_Count;

                if (first_Count == 1)
                {
                    if (hasPlayedOfPlayer1[1 + _ty * 3] == 0)

                            return 1 + _ty * 3;
                    if (hasPlayedOfPlayer1[2 + _ty * 3] == 0)

                             return 2 + _ty * 3;
                    if (hasPlayedOfPlayer1[3 + _ty * 3] == 0)
                             return 3 + _ty * 3;

                }
                else
                    first_Count = 0;


                if (hasPlayedOfPlayer1[_ty + 1] == 0)


                    ++second_Count;
                if (hasPlayedOfPlayer1[_ty + 4] == 0)

                    ++second_Count;
                if (hasPlayedOfPlayer1[_ty + 7] == 0)


                    ++second_Count;
                if (second_Count == 1)
                {
                    if (hasPlayedOfPlayer1[_ty + 1] == 0)


                        return _ty + 1;
                    if (hasPlayedOfPlayer1[_ty + 4] == 0)

                        return _ty + 4;
                    if (hasPlayedOfPlayer1[_ty + 7] == 0)


                        return _ty + 7;

                }
                else
                {
                    second_Count = 0;
                }
            }

            /////////////////////////////////////////////
            if (hasPlayedOfPlayer1[1] == 0)
                ++three_Count;

            if (hasPlayedOfPlayer1[5] == 0)
                ++three_Count;

            if (hasPlayedOfPlayer1[9] == 0)
                ++three_Count;

            if (three_Count == 1)
            {
                if (hasPlayedOfPlayer1[1] == 0)
                    return 1;

                if (hasPlayedOfPlayer1[5] == 0)
                    return 5;

                if (hasPlayedOfPlayer1[9] == 0)
                    return 9;
            }
            else
            {
                three_Count = 0;
            }
            if (hasPlayedOfPlayer1[3] == 0)
                ++four_Count;
            if (hasPlayedOfPlayer1[5] == 0)
                ++four_Count;
            if (hasPlayedOfPlayer1[7] == 0)
                ++four_Count;
            if (four_Count == 1)
            {

                if (hasPlayedOfPlayer1[3] == 0)
                    return 3;
                if (hasPlayedOfPlayer1[5] == 0)
                    return 5;
                if (hasPlayedOfPlayer1[7] == 0)
                    return 7;
            }
            else
            {
                four_Count = 0;
            }
            return 0;

        }
        #region
        public int Withplayer1_1andNoplayer2()
        {
            for (int _t = 0; _t < 3; ++_t)
            {
                if ((hasPlayedOfPlayer1[1 + (_t * 3)] == 0
                    && hasPlayedOfPlayer1[2 + (_t * 3)] == 0
                            && hasPlayedOfPlayer1[3 + (_t * 3)] == 1))
                        {
                             if (hasPlayedOfPlayer2[1 + (_t * 3)] == 0
                                && hasPlayedOfPlayer2[2 + (_t * 3)] == 0
                                && hasPlayedOfPlayer2[3 + (_t * 3)] == 0)
                            {
                                return 1+(_t*3);
                            }
                        }
                            if((hasPlayedOfPlayer1[1 + (_t * 3)] == 1
                            && hasPlayedOfPlayer1[2 + (_t * 3)] == 0
                            && hasPlayedOfPlayer1[3 + (_t * 3)] == 0))
                            {
                             if (hasPlayedOfPlayer2[1 + (_t * 3)] == 0
                                && hasPlayedOfPlayer2[2 + (_t * 3)] == 0
                                && hasPlayedOfPlayer2[3 + (_t * 3)] == 0)
                            {
                                return 2+(_t*3);
                            }
                            }
                            if((hasPlayedOfPlayer1[1 + (_t * 3)] == 0
                            && hasPlayedOfPlayer1[2 + (_t * 3)] == 1
                            && hasPlayedOfPlayer1[3 + (_t * 3)] == 0))
                        {
                            if (hasPlayedOfPlayer2[1 + (_t * 3)] == 0
                                && hasPlayedOfPlayer2[2 + (_t * 3)] == 0
                                && hasPlayedOfPlayer2[3 + (_t * 3)] == 0)
                            {
                                return 3+(_t*3);
                            }
                        }
                        if ((hasPlayedOfPlayer1[1 + _t] == 0
                         && hasPlayedOfPlayer1[4 + _t] == 0
                         && hasPlayedOfPlayer1[7 + _t] == 1))
                        {
                              if (hasPlayedOfPlayer2[1 + _t] == 0
                                && hasPlayedOfPlayer2[2 + _t] == 0
                                && hasPlayedOfPlayer2[3 + _t] == 0)
                            {
                                return 1+_t;
                            }
                        }
                         if((hasPlayedOfPlayer1[1 + _t] == 1
                         && hasPlayedOfPlayer1[4 + _t] == 0
                         && hasPlayedOfPlayer1[7 + _t] == 0))
                         {
                             if (hasPlayedOfPlayer2[1 + _t] == 0
                                && hasPlayedOfPlayer2[4 + _t] == 0
                                && hasPlayedOfPlayer2[7 + _t] == 0)
                            {
                                    return 4+_t;
                            }
                         }
                         if((hasPlayedOfPlayer1[1 + _t] == 0
                         && hasPlayedOfPlayer1[4 + _t] == 1
                         && hasPlayedOfPlayer1[7 + _t] == 0))
                        {
                            if (hasPlayedOfPlayer2[1 + _t] == 0
                                && hasPlayedOfPlayer2[4 + _t] == 0
                                && hasPlayedOfPlayer2[7 + _t] == 0)
                            {
                                return 7+_t;
                            }
                        }
            }
                        if ((hasPlayedOfPlayer1[1] == 0
                            && hasPlayedOfPlayer1[5] == 0
                            && hasPlayedOfPlayer1[9] == 1))
                        {
                               if (hasPlayedOfPlayer2[1] == 0
                                && hasPlayedOfPlayer2[5] == 0
                                && hasPlayedOfPlayer2[9] == 0)
                            {
                                return 1;
                            }
                        }
                            if((hasPlayedOfPlayer1[1] == 1
                            && hasPlayedOfPlayer1[5] == 0
                            && hasPlayedOfPlayer1[9] == 0))
                            {

                                 if (hasPlayedOfPlayer2[1] == 0
                                && hasPlayedOfPlayer2[5] == 0
                                && hasPlayedOfPlayer2[9] == 0)
                            {
                                return 5;
                            }
                            }
                            if((hasPlayedOfPlayer1[1] == 0
                            && hasPlayedOfPlayer1[5] == 1
                            && hasPlayedOfPlayer1[9] == 0))
                        {
                            if (hasPlayedOfPlayer2[1] == 0
                                && hasPlayedOfPlayer2[5] == 0
                                && hasPlayedOfPlayer2[9] == 0)
                            {
                                return 9;
                            }
                        }
                        if ((hasPlayedOfPlayer1[3] == 0
                         && hasPlayedOfPlayer1[5] == 0
                         && hasPlayedOfPlayer1[7] == 1))
                        {
                             if (hasPlayedOfPlayer2[3] == 0
                                && hasPlayedOfPlayer2[5] == 0
                                && hasPlayedOfPlayer2[7] == 0)
                            {
                                return 3;
                            }
                        }
                         if((hasPlayedOfPlayer1[3] == 1
                         && hasPlayedOfPlayer1[5] == 0
                         && hasPlayedOfPlayer1[7] == 0))
                         {
                               if (hasPlayedOfPlayer2[3] == 0
                                && hasPlayedOfPlayer2[5] == 0
                                && hasPlayedOfPlayer2[7] == 0)
                            {
                                return 5 ;
                            }
                         }
                         if((hasPlayedOfPlayer1[3] == 0
                         && hasPlayedOfPlayer1[5] == 1
                         && hasPlayedOfPlayer1[7] == 0))
                        {
                            if (hasPlayedOfPlayer2[3] == 0
                                && hasPlayedOfPlayer2[5] == 0
                                && hasPlayedOfPlayer2[7] == 0)
                            {
                                return 7;
                            }
                        }



                    return 0;
                }
                #endregion

#region 
        public int RandomPlayer1Place()
        {
            for (int _T = 1; _T <=9; ++_T)
            {
                if (hasPlayedOfPlayer1[_T] == 0 && hasPlayedOfPlayer2[_T] == 0)
                {
                    return _T;
                }
            }
            return 0;
        }
#endregion

        protected void Start_Click(object sender, EventArgs e)
        {
              Which_player = 1;

              for (int _t = 1; _t < 10;++_t )
              {
                  hasPlayedOfPlayer1[_t] = 0;
                  hasPlayedOfPlayer2[_t] = 0;
                  curButtonNumber[_t] = 0;
              }

              btn1.BackColor = SystemColor;
              btn2.BackColor = SystemColor;
              btn3.BackColor = SystemColor;
              btn3.BackColor = SystemColor;
              btn4.BackColor = SystemColor;
              btn5.BackColor = SystemColor;
              btn6.BackColor = SystemColor;
              btn7.BackColor = SystemColor;
              btn8.BackColor = SystemColor;
              btn9.BackColor = SystemColor;

          

        theTimeOfPlayer1 = 0;
        theTimeOfPlayer2 = 0;
             win = 0;

       
       //Stack of Button


        indexCurButtonNumber = 1;


       index_1 =  0;
        }
    }
}









