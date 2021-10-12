#include "stdio.h"
#include "stdlib.h"

int main()
{
    char card_name[3];  

    puts("输入牌名: ");
    scanf("%2s",card_name);
    
    int val = 0 ;
    if (card_name[0] == 'K'){
        val = 10 ;
    }else if (card_name[0] == 'Q'){
        val = 10 ;
    }else if (card_name[0] == 'J'){
        val = 10 ;
    }else if (card_name[0] == 'A'){
        val = 11 ;
    }else{
        val=atoi(card_name);
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
