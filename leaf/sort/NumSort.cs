using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaf.sort
{
    class Num
    {
//        C+- OmniWorks Replacement History - ds_pl3d`pl3d:Sort.for;6
//C       6*[1858145] 12-SEP-2014 14:14:39 (GMT) OKresse
//C         "New output file and less messages to screen"
//C       5*[1854456] 20-AUG-2014 23:16:11 (GMT) OKresse
//C         "New accelerations from HPC group"
//C       4*[1842380] 17-JUN-2014 19:05:36 (GMT) OKresse
//C         "Cleaning"
//C       3*[1823181] 03-MAR-2014 20:26:08 (GMT) OKresse
//C         "Implementing dynamic arrays"
//C       2*[646911] 03-NOV-2004 16:40:08 (GMT) JAdachi
//C         "Put some routines of the code up to standard"
//C       1*[602324] 22-JUL-2004 08:42:20 (GMT) wsv_admin
//C         "Alpha2 release 2 PL3D engine"
//C+- OmniWorks Replacement History - ds_pl3d`pl3d:Sort.for;6

//C OmniWorks Replacement History(migrated from DWL version 3)

//C+- OmniWorks Replacement History - ds_pl3d`pl3d:Sort.for;3 
//C       3*[ 59107] 20-NOV-2003 23:14:56 (GMT) SIEBRITS
//C         "Change PAUSE so that ignored in RELEASE mode" 
//C       2*[ 52638] 27-NOV-2002 00:17:00 (GMT) adachi
//C         "PL3D all" 
//C       1*[ 50294] 11-JUL-2002 18:49:22 (GMT) SIEBRITS
//C         "Alpha2 release 2 PL3D engine" 
//C+- OmniWorks Replacement History - ds_pl3d`pl3d:Sort.for;3 
//C------------------------------------------------------------------------------
//C--                                                                          --
//C--    (C) COPYRIGHT SCHLUMBERGER.THIS PROGRAM IS A CONFIDENTIAL           --
//C--    UNPUBLISHED WORK OF AUTHORSHIP CREATED IN 2002 AND IS THE PROPERTY    --
//C--    OF SCHLUMBERGER.  ALL USE, DISCLOSURE, AND/OR REPRODUCTION            --
//C--    NOT SPECIFICALLY AUTHORIZED BY SCHLUMBERGER IS PROHIBITED.            --
//C--    ALL RIGHTS RESERVED.                                                  --
//C--                                                                          --
//C------------------------------------------------------------------------------
//C
//C PROGRAM UNIT HEADER****************************************************
//C NAME
//C sort
//C
//C SPECIAL REQUIREMENTS AND NOTES
//C Sorting routine, adjusted from Numerical Recipes.
//C Output in ascending order
//C
//C This routine, sort, is based on routine sort
//C from the book "Numerical Recipes in FORTRAN" (Cambridge University Press), 
//C Copyright(C) 1986, 1992 by Numerical Recipes Software.Used by Permission. 
//C Use of this routine other than as an integral part of Mangrove requires
//C an additional license from Numerical Recipes Software.
//C Further distribution in any form is prohibited
//C HISTORY
//C Created in       by
//C************************************************************************
//C
//     SUBROUTINE sort(
//     .          n,      !i size of vector    
//     .          nstack, !i max size of vector
//    .arr,    !i/o unsorted/sorted vector
//     .          indx)   !o index vector
//c
//      implicit double precision(a-h, o-z)
//c
//      INTEGER n,M,NSTACK
//      dimension arr(nstack)
//      PARAMETER(M= 7)
//      INTEGER i, ir1, j, jstack, k, l, istack(NSTACK), indx(nstack)
//ccc      dimension a, temp
//c
//c...find reference indices for data
//      call indexx(n, nstack, arr, indx)
//c
//      jstack = 0
//      l = 1
//      ir1 = n
//1     if(ir1 - l.lt.M)then
//        do 12 j = l + 1, ir1
//          a = arr(j)
//          do 11 i = j - 1, 1, -1
//            if(arr(i).le.a)goto 2
//            arr(i + 1) = arr(i)
//11        continue
//          i = 0
//2         arr(i + 1) = a
//12      continue
//        if(jstack.eq.0)return
//        ir1=istack(jstack)
//        l=istack(jstack-1)
//        jstack=jstack-2
//      else
//        k=(l+ir1)/2
//        temp=arr(k)
//        arr(k)=arr(l+1)
//        arr(l+1)=temp
//        if(arr(l+1).gt.arr(ir1))then
//          temp = arr(l + 1)
//          arr(l+1)=arr(ir1)
//          arr(ir1)=temp
//        endif
//        if(arr(l).gt.arr(ir1))then
//          temp = arr(l)
//          arr(l)=arr(ir1)
//          arr(ir1)=temp
//        endif
//        if(arr(l+1).gt.arr(l))then
//          temp = arr(l + 1)
//          arr(l+1)=arr(l)
//          arr(l)=temp
//        endif
//        i=l+1
//        j=ir1
//        a = arr(l)
//3       continue
//          i=i+1
//        if(arr(i).lt.a)goto 3
//4       continue
//          j=j-1
//        if(arr(j).gt.a)goto 4
//        if(j.lt.i)goto 5
//        temp=arr(i)
//        arr(i)=arr(j)
//        arr(j)=temp
//        goto 3
//5       arr(l)=arr(j)
//        arr(j)=a
//        jstack = jstack + 2
//        if(jstack.gt.NSTACK)then
//        write(*,10)

//        write(700,10)
//c$IF DEFINED(DEBUG)
//c pause
//c$ENDIF
//      endif
//        if(ir1-i+1.ge.j-l)then
//          istack(jstack)=ir1
//          istack(jstack-1)=i
//          ir1 = j - 1
//        else
//          istack(jstack)=j-1
//          istack(jstack-1)=l
//          l = i
//        endif
//      endif
//      goto 1
//c
//   10 format('SORT: NSTACK too small.')
//c
//      END
//C(C) Copr. 1986-92 Numerical Recipes Software.

        public static void index()
        {
//            C + -OmniWorks Replacement History -ds_pl3d`pl3d: Indexx.for; 6
// C       6 *[1858145] 12 - SEP - 2014 14:14:39(GMT) OKresse
// C         "New output file and less messages to screen"
// C       5 *[1854456] 20 - AUG - 2014 23:16:11(GMT) OKresse
// C         "New accelerations from HPC group"
// C       4 *[1842380] 17 - JUN - 2014 19:05:36(GMT) OKresse
// C         "Cleaning"
// C       3 *[1823181] 03 - MAR - 2014 20:26:08(GMT) OKresse
// C         "Implementing dynamic arrays"
// C       2 *[646911] 03 - NOV - 2004 16:40:08(GMT) JAdachi
// C         "Put some routines of the code up to standard"
// C       1 *[602322] 22 - JUL - 2004 08:32:24(GMT) wsv_admin
// C         "Alpha2 release 2 PL3D engine"
// C + -OmniWorks Replacement History - ds_pl3d`pl3d:Indexx.for; 6
  

//  C OmniWorks Replacement History(migrated from DWL version 3)
  

//  C + -OmniWorks Replacement History - ds_pl3d`pl3d:Indexx.for; 3
//   C       3 *[59107] 20 - NOV - 2003 23:14:56(GMT) SIEBRITS
//   C         "Change PAUSE so that ignored in RELEASE mode"
//   C       2 *[52638] 27 - NOV - 2002 00:17:00(GMT) adachi
//   C         "PL3D all"
//   C       1 *[50294] 11 - JUL - 2002 18:49:22(GMT) SIEBRITS
//   C         "Alpha2 release 2 PL3D engine"
//   C + -OmniWorks Replacement History - ds_pl3d`pl3d:Indexx.for; 3
//    C------------------------------------------------------------------------------
//    C----
//    C--(C) COPYRIGHT SCHLUMBERGER.THIS PROGRAM IS A CONFIDENTIAL--
//    C--    UNPUBLISHED WORK OF AUTHORSHIP CREATED IN 2002 AND IS THE PROPERTY--
//    C--    OF SCHLUMBERGER.ALL USE, DISCLOSURE, AND / OR REPRODUCTION--
//    C--    NOT SPECIFICALLY AUTHORIZED BY SCHLUMBERGER IS PROHIBITED.            --
//    C--    ALL RIGHTS RESERVED.                                                  --
//    C----
//    C------------------------------------------------------------------------------
//    C
//    C PROGRAM UNIT HEADER * ***************************************************
//    C NAME
//    C indexx
//    C
//    C SPECIAL REQUIREMENTS AND NOTES
//    C
//    C This routine, indexx, is based on routine indexx
//    C from the book "Numerical Recipes in FORTRAN"(Cambridge University Press),
//    C Copyright(C) 1986, 1992 by Numerical Recipes Software.Used by Permission.
//    C Use of this routine other than as an integral part of Mangrove requires
//    C an additional license from Numerical Recipes Software.
//    C Further distribution in any form is prohibited
//    C HISTORY
//    C Created in         by
//    C * ***********************************************************************
//    C
    
//          SUBROUTINE indexx(
//     .          n, !i actual size of vector
//         .nstack, !i max size of vector
//         .arr, !i vector to index
//         .indx)    !o index vector
//    c
//      implicit double precision(a-h, o-z)
//c
//      INTEGER n,indx(nstack),M,NSTACK
//      dimension arr(nstack)
//      PARAMETER(M= 7)
//      INTEGER i, indxt, ir1, itemp, j, jstack, k, l, istack(NSTACK)
//ccc      dimension a
//c
//      do 11 j = 1, n
//        indx(j) = j
//11    continue
//      jstack = 0
//      l = 1
//      ir1 = n
//1     if(ir1 - l.lt.M)then
//        do 13 j = l + 1, ir1
//          indxt = indx(j)
//          a = arr(indxt)
//          do 12 i = j - 1, 1, -1
//            if(arr(indx(i)).le.a)goto 2
//            indx(i + 1) = indx(i)
//12        continue
//          i = 0
//2         indx(i + 1) = indxt
//13      continue
//        if(jstack.eq.0)return
//        ir1=istack(jstack)
//        l=istack(jstack-1)
//        jstack=jstack-2
//      else
//        k=(l+ir1)/2
//        itemp=indx(k)
//        indx(k)=indx(l+1)
//        indx(l+1)=itemp
//        if(arr(indx(l+1)).gt.arr(indx(ir1)))then
//          itemp = indx(l + 1)
//          indx(l+1)=indx(ir1)
//          indx(ir1)=itemp
//        endif
//        if(arr(indx(l)).gt.arr(indx(ir1)))then
//          itemp = indx(l)
//          indx(l)=indx(ir1)
//          indx(ir1)=itemp
//        endif
//        if(arr(indx(l+1)).gt.arr(indx(l)))then
//          itemp = indx(l + 1)
//          indx(l+1)=indx(l)
//          indx(l)=itemp
//        endif
//        i=l+1
//        j=ir1
//        indxt = indx(l)
//        a=arr(indxt)
//3       continue
//          i=i+1
//        if(arr(indx(i)).lt.a)goto 3
//4       continue
//          j=j-1
//        if(arr(indx(j)).gt.a)goto 4
//        if(j.lt.i)goto 5
//        itemp=indx(i)
//        indx(i)=indx(j)
//        indx(j)=itemp
//        goto 3
//5       indx(l)=indx(j)
//        indx(j)=indxt
//        jstack = jstack + 2
//        if(jstack.gt.NSTACK)then
//         write(*,10)

//         write(700,10)
//c$IF DEFINED(DEBUG)
//c pause
//c$ENDIF
//      endif
//        if(ir1-i+1.ge.j-l)then
//          istack(jstack)=ir1
//          istack(jstack-1)=i
//          ir1 = j - 1
//        else
//          istack(jstack)=j-1
//          istack(jstack-1)=l
//          l = i
//        endif
//      endif
//      goto 1
//c
//      return
//c
//   10 format('INDEXX: NSTACK too small in indexx')
//c
//      END
//C(C) Copr. 1986-92 Numerical Recipes Software.

        }
}
}
