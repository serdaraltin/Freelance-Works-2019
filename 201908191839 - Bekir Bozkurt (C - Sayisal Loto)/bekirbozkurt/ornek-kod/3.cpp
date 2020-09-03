/* assignment2 of semester 2
    This program will play the Lotto game. This program allows the user to enter their 6 selected 
    numbers and they have a set of options, each performing a specific requirement. 6 selected
    numbers are stored in a 1-Dimensional array.
    Using functions and pointer notations to access array
    
    a. Read the 6 selected numbers from the keyboard. Perform any necessary 
        validation (error-checking) required (e.g. all numbers must be different, range 
        1-42, etc.). 
    b. Display the contents of the 1-D array containing your lotto numbers that you 
        entered. 
    c. Sort the contents of the array in increasing order (i.e. 1st element = smallest 
        number, 2nd element = 2nd smallest number, etc.). You may use any sorting 
        algorithm of your choice. 
    d. Compare your chosen lotto numbers in the 1-D array with the following 
        winning numbers: 
        1 ,3,5,7,9,11 - 42 (Bonus number) 
    e. Display the frequency of the numbers entered each time the user enters a new 
        set of numbers (without exiting the program) on the screen. For example, it 
        might display: 
        number 1 has been selected x times 
        number 7 has been selected x times 
    f. Exit program 

    Author: Ben Joshua Daan
    Date: March 15 2014
*/

#include <stdio.h>
#define SELECTED 6 //part1, part2 and part3 functions
#define LOTTO 6 // global array for fourth function
#define SIZE 42 //the size of the lotto numbers

//Declare prototypes
void part1(int*,int*); // first function, will pass down 2 functions
void part2(int*); // second function
void part3(int*); //third function
void part4(int*, int*);  // fourth function , it will pass down 2 functions to compare
void part5(int*); //fifth function

main()
{
    char options;
    int values[SELECTED]; // the array name for user input
    int array[] = {1,3,5,7,9,11,42}; //part4 function uses this array
    // the array element starts at 0 so SIZE +1 will put a number inside element 0
    int frequency[SIZE+1]={0};
    int opt_b_first=0; //to check if the user picks option b in their first try
    int opt_c_first=0; //to check if the user picks option c in their first try
    int opt_d_first=0; //to check if the user picks option d in their first try
    int opt_e_first=0; //to check if the user picks option e in their first try
    
    do
    {
        //Menu
        printf("\n");
        printf("*******************************************************\n");
        puts("Menu");
        puts("a.)Enter six different numbers to play the Lotto");
        puts("b.)Display the six numbers you have selected");
        puts("c.)To sort the numbers you have entered");
        puts("d.)To compare your six selected numbers with the winning numbers");
        puts("e.)Check how many times you have entered the same number");
        printf("f.)Game stops \n \n");
        
        printf("Please pick one of the options above \n");
        printf("*******************************************************\n");
        printf("\n");
        scanf("%1s", &options);
        
        if(options == 'a')
        {
            //values is the array of numbers that the user has inputted
            part1(values,frequency);
            /* Makes sure that the user does not pick option b,c,d or e on their first try
                            but it increments the variable of option b,c,d and e after option a has finished
                            and so allows the other options to be executed 
                        */
            opt_b_first++;
            opt_c_first++;
            opt_d_first++;
            opt_e_first++;
            
        }//end if
        
        else if(options == 'b')
        {
            if(opt_b_first >0)
            {
                part2(values);//values is the array of numbers that the user has inputted
            }//end if
            else //if user does enter option b in their first try
            {
                puts("ERROR! you cannot pick option b in your first try");
                puts("Please pick option a to input your 6 selected numbers");
            }//end else
        }//end else if
        
        else if(options == 'c')
        {
            if(opt_c_first >0)
            {
                part3(values);
            }//end if
            else //if user does enter option c in their first try
            {
                puts("ERROR! you cannot pick option c in your first try");
                puts("Please pick option a to input your 6 selected numbers");
            }//end else
        }//end else if
        
        else if(options == 'd')
        {
            if(opt_d_first >0)
            {
                part4(array,values);
            }//end if
            else //if user does enter option d in their first try
            {
                puts("ERROR! you cannot pick option d in your first try");
                puts("Please pick option a to input your 6 selected numbers");
            }//end else
        }//end else if
        
        /*Implement function 5 here! */
        else if(options == 'e')
        {
            if(opt_e_first >0)
            {
                part5(frequency); /* Makes sure that the user does not pick option e first
                                                                but it increments this variable after option d has finished
                                                                and so allows option b to be executed 
                                                            */
            }//end if
            else
            {
                puts("ERROR! you cannot pick option e in your first try");
                puts("Please pick option a to input your 6 selected numbers");
            }//end else
        }//end else if           
        
        //if the user inputs inappropriate options and numbers to play the lotto
        else if(options!='a'&&options!='b'&&options!='c'&&options!='d'&&options!= 'e'&&options!='f')
        {
            puts("Invalid input");
        }//end else if
    }while (options != 'f');
    puts("Thank you for playing this Lotto game");
    
   // flushall();
    getchar();
}//end main()

/*Implement function part1 */
/*This functions reads in the 6 lotto numbers that the user has picked */
//numbers are the ones that the user has selected for the lotto
//freq pointer determines how many times a certain number has been inputted
void part1(int *numbers,int *freq)
{
    int i,j;
    int temp; // a temporary variable to hold each number inputted
    
    puts("a.) Enter six different numbers to play the Lotto");
    printf("Please enter six different numbers \n");
    
    for(i=0; i<SELECTED; i++)
    {   
        scanf("%d", & *(numbers + i));
        /* the if statement checks if the user inputs numbers outside the range of 1 - 42 */
        if (*(numbers + i) >= 1 && *(numbers + i) <= 42)
        {
            /*this checks if the user inputs the same number inside the array */
            for(j=0; j < i;j++)
            {
                if(*(numbers +i) == *(numbers +j))
                {
                    puts("You cannot enter the same number");
                    puts("The game will restart");
                    return; //it returns back to the menu if the user inputs the same number
                }//end inner if
            }//end inner for loop for checking
        }//end if
        /* the else statement confirms that the user input numbers outside the range of 1 - 42 */
        else
        {
            printf("You must enter numbers within the range of 1-42\n");
            printf("The program will restart \n");
            printf("\n"); //for neatness
            break; /*allows the function to be executed again untill user inputs correct
                                                numbers 
                                        */
        }//end else
        temp= *(numbers +i);/*outs each number inputted by user into the respective array
                                                            element 
                                                        */
        *(freq +temp) = *(freq +temp) +1;/*this gets incremented to determine how many
                                                                                    times a certain number has been inputted by 
                                                                                    the user during the course of the game
                                                                                */
    }//end for
}//end function part1

/* Implement function part2 */
/*This function displays the lotto numbers inputted by the user */
void part2(int *display)
{
    int i;
    
    puts("b.) Display the six numbers you have selected");
    for(i=0; i<SELECTED; i++)
    {
        printf("The numbers you have entered are: %d \n", *(display + i));
    }//end for
}//end function 2

/*Implement function part3 */
/*This function sorts the 6 lotto numbers in ascending order e.g 1,2,3,4..... */
void part3(int *sort)
{
    int min; //looks for the smallest number in the array and places it in the first element
    int temp; //is used for swapping numbers, just a temporary variable
    int i,j;
    
    //start selection sort
    /*
            selection sort looks throughout the array to find the smallest number and sorts it
            in ascending order 
        */
    for(i=0; i<SELECTED-1; i++)
    {
        min=i;
        for(j=i+1; j<SELECTED; j++)
        {
            if(sort[j] < sort[min])
            {
                min = j;
            }
        }//end for
        temp = sort[min];
        sort[min] = sort[min];
        sort[min] = sort[i];
        sort[i] = temp;
    }//end for
    
    printf("The sorted numbers are: \n");
    for(i=0; i<SELECTED; i++)
    {
        printf("%d, ", *(sort + i)); //it aranges the numbers in ascending formation
    }//end for
}//end function 3

/*Implement function 4 */
/*this function compares the winning lotto numbers with the user's chosen lotto numbers */
//compare are winning numbers and values are user input
void part4(int *compare,int *values)
{
    int match = 0; //a counter to see how many matched numbers did the user got
    int bonus= *(compare +6); //bonus number of the winning LOTTO numbers
    int bonus_counter; // a counter to see if the user got the bonus number 42
    int i,j;
    
    bonus_counter = 0;
    
    printf("\n");
    puts("---------------------------------------------------");
    puts("| Six matches = JACKPOT!                          |");
    puts("| 5 matches and a bonus number = New car          |");
    puts("| 5 matches = Holiday                             |");
    puts("| 4 matches and a bonus number = Weekend away     |");
    puts("| 4 matches = Nightout                            |");
    puts("| 3 matches and a bonus = a Cinema Ticket         |");
    puts("| No matches = No prize                           |");
    puts("---------------------------------------------------");
    
    puts("d.) To compare your six selected numbers with the winning numbers");
    //outer for loop acts like a counter
    for(i=0; i<LOTTO; i++)
    {
        for(j=0;j<LOTTO;j++)
        {
            //inner for loop checks if the values user inputted matches the winning numbers
            if(*(compare +j) == *(values + i))
            {
                match++;
                printf("The matching numbers are:winning number %d and your number %d \n",*(compare + j),*(values + i));
            }//end if
        }//end inner for loop
        if(*(values + i) == bonus)
        {
            puts("You also got the bonus number which is 42!");
            bonus_counter++;
        }//end if
    }//end outer for()
    
    /*These determines if the user wins anything */
    if(match == 6)
    {
        puts("Jackpot!");
    }//end if
    else if(match ==5 && bonus_counter == 1)
    {
        puts("You win a new car!");
    }//end else if
    else if(match ==5)
    {
        puts("You win a Holiday in Hawaii!");
    }//end else if
    else if(match==4 && bonus_counter == 1)
    {
        puts("You got a weekend away");
    }//end else if
    else if(match ==4)
    {
        puts("You win a free Night Out");
    }//end else if
    else if(match==3 && bonus_counter == 1)
    {
        puts("You win a Cinema Ticket");
    }//end else if
    else if(match==3|| match==2 || match ==1 )
    {
        puts("You didn't win anything");
    }//end else if
    
    else if(match!=6 && match!=5 && match!=4 && match!=3 && bonus_counter!=1 )
    {
        puts("You didnt get any of the matching numbers");
    }// end else if
}//end function  part 4

/*Implement function 5 */
/*This function keeps track on how many times a particular number has been inputted by the user */
void part5(int *frequency)
{
    int i;
    
    puts("e.)Check how many times you have entered the same number");
    for(i=0; i<SIZE+1; i++)
    {
        //if statement displays how many times a certain number has been inputted 
        if(*(frequency + i) != 0)
        {
            printf("Number %d has been selected %d times \n",i,*(frequency +i));
        }//end if
    }//end for
}//end function part 5
