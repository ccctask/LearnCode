#include "stdio.h"
int main()
{
    /* code */
    // 双引号是 字符串字面量  是一个常量 不能修改 否则会 bus error ,总线错误 意味：程序无法更新那一块 存储空间。
    char name[]="test";

    char othername[3]="ab";
    printf("当前name为: %s\n", name);
    printf("othername为: %s\n", othername);
    
    othername[1]="m";
    printf("new_othername为: %s\n", othername);
    return 0;
}
