#include "stdio.h"
#include "stdlib.h"

int main()
{
    /* code */
    /* C 中没有字符串类型，使用字符数组代替，需要知道什么时候结束字符=哨兵字符 \O =ASCII 值为0
     * 需要使用两个字符，声明需要 3个字符数组。
    */ 
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

    printf("这张牌的点数是: %i\n", val);
    return 0;

/* 
1. 为什么字符从0开始编号： 因为字符的索引值 是一个偏移量，表示当前到第一个字符间有多少个字符。
   计算机在存储器中 以连续字节 保存字符，如果知道 C[0] 在某个存储单元，通过偏移量更快地找到 C[99]
*/

}
