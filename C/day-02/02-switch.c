#include "stdio.h"
#include "stdlib.h"

int main()
{
    char card_name[3];  

    puts("输入牌名: ");
    scanf("%2s",card_name);
    
    int val = 0 ;
    switch (card_name[0])
    {
    // case 'K':
    //     val = 10;
    //     break;
    // case 'Q':
    //     val = 10 ;
    //     break;
    // case 'J':
    //     val = 10 ;
    //     break;
    case 'K':
    case 'Q':
    case 'J':
        val = 10;
        break;
    case 'A':
        val = 11 ;
        break;
    default:
        val = atoi(card_name);
        puts("Invalid card");
        break;
    }

    if ((val >= 3) && (val <= 6 )){
        puts("计数器增加");
    }
    // else if((val == 10)||(val =='J')||(val =='Q')||(val =='K')) 因为 JQKA 都会 等于 10 ，所以不用列出来了。
    else if(val==10)
    {
        puts("计数器减少");
    }
    return 0;


}
