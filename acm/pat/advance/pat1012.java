class Stu
{
    c,m,e,a
}

array stus[] <= input data
map id2stu <= <id str, stu>

stusc = Arrays.copy(stus)
Arrays.sort(stusc, comparator by c filed)

stusm = Arrays.copy(stusc)
Arrays.sort(stusm,comparator by m filed)

stuse = Arrays.copy(stusc)
Arrays.sort(stusm,comparator by e filed)

stusa = Arrays.copy(stusc)
Arrays.sort(stusm,comparator by a filed)

for each id str
    get stu from id2stu map by id str
    no_c = binary search stusc by stu.c, find around that id str statisfied

    if not found
        print N/A
    else
        no_m = binary search stusm by stu.m, find around that id str statisfied
        no_e = binary search stusm by stu.e, find around that id str statisfied
        no_a = binary search stusm by stu.a, find around that id str statisfied

    

