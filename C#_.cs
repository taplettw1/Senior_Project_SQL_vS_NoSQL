// See https://aka.ms/new-console-template for more information


using Cassandra;
using System;


var cluster = Cluster.Builder()

               .AddContactPoint("127.0.0.1")

               .Build();

var session = cluster.Connect("game_stop");




    //      EMPLOYEES

session.Execute(" iNSeRT INto employees ( id , first_name , last_name , hire , position , salary , phone , e_mail , store_no ) ValueS ( uuid()  ,  ' Anthony'   , ' Taplett ' , '2020-08-23' , ' Manager' ,       25 , ' [832] 911 - 3110 ' , ' ant@gator.com ' ,  8 ) ; " ) ;

session.Execute(" iNSeRT INto employees ( id , first_name , last_name , hire , position , salary , phone , e_mail , store_no ) ValueS ( uuid()  ,  ' William ' , ' Pham ' , '2020-12-10' , ' Supervisor '     , 15 , ' [713] 444 - 6666 ' , ' will@gmail.com ' ,  5 ) ; " ) ;

session.Execute(" iNSeRT INto employees ( id , first_name , last_name , hire , position , salary , phone , e_mail , store_no ) ValueS ( uuid()  ,  ' Barack ' , ' Obama ' , '2020-10-31' , ' Cashier ' ,        10 , ' [281] 999 - 0000 ' , ' obamacare@aol.com ' ,  3 ) ; " ) ;

session.Execute(" iNSeRT INto employees ( id , first_name , last_name , hire , position , salary , phone , e_mail , store_no ) ValueS ( uuid()  , ' Mike '    , ' Tyson ' , '2025-02-14' , ' Assistant Manager ' ,    15 , ' [346] 1234 - 4567 ' , ' tysonfight@arena.com ' ,  4 ) ; " ) ;

session.Execute(" iNSeRT INto employees ( id , first_name , last_name , hire , position , salary , phone , e_mail , store_no ) ValueS ( uuid()  , ' Donald '  , ' Trum ' , '2025-03-16' , ' Cashier' ,           10 , ' [911] 246 - 1357 ' , ' trump@whitehouse.com ' ,  6 ) ; " ) ;

session.Execute(" iNSeRT INto employees ( id , first_name , last_name , hire , position , salary , phone , e_mail , store_no ) ValueS ( uuid()  , ' Larry '   , ' Bird ' , '2010-12-12' , ' Supervisor ' ,            15 , ' [242] 111 - 4444 ' , ' bird@celtics.com ' ,  8 ) ; " ) ;

session.Execute(" iNSeRT INto employees ( id , first_name , last_name , hire , position , salary , phone , e_mail , store_no ) ValueS ( uuid()  , ' Patrick ' , ' Mahomes ' , '2015-07-15' , ' Assistant Manager' , 20 , ' [946] 898 - 0909 ' , ' patrick@chiefs.com ' ,  3 ) ; " ) ;

session.Execute(" iNSeRT INto employees ( id , first_name , last_name , hire , position , salary , phone , e_mail , store_no ) ValueS ( uuid()  , ' Snoop '   , ' Dogg ' , '2019-05-09' , ' Manager' ,           25 , ' [721] 222 - 1212 ' , ' snoop@deathrow.com ' ,  5 ) ; " ) ;

session.Execute(" iNSeRT INto employees ( id , first_name , last_name , hire , position , salary , phone , e_mail , store_no ) ValueS ( uuid()  , ' Jose '    , ' Altuve ' , '2022-09-02' , ' Cashier'         , 10 , ' [654] 456 - 4321 ' , ' jose@astros.com ' ,  8 ) ; " ) ;

session.Execute(" iNSeRT INto employees ( id , first_name , last_name , hire , position , salary , phone , e_mail , store_no ) ValueS ( uuid()  , ' Simone '  , ' Biles ' , '2018-08-18' , ' Cashier '         , 10 , ' [321] 980 - 0123 ' , ' simone@instagram.com ' ,  5 ) ; " ) ;



//      MEMBERS

session.Execute(" iNSeRT INto members ( id , first_name , last_name , sign_up , points , phone , e_mail , store_no )   ValueS ( uuid() , 'Sarah '      , 'James '      ,   '2020-04-07' ,  999    ,  ' [713} 411-7000'  , 'sar@gator.uhd.edu'     , 6 ) ; " ) ;

session.Execute(" iNSeRT INto members ( id , first_name , last_name , sign_up , points , phone , e_mail , store_no )   ValueS ( uuid() , 'Elizabeth '  , 'Moore '      ,   '1980-03-16' ,  10000  ,  ' [832} 985-2432'  , 'eliz@gmail.com'        , 3 ) ; " ) ;

session.Execute(" iNSeRT INto members ( id , first_name , last_name , sign_up , points , phone , e_mail , store_no )   ValueS ( uuid() , 'Michelle '   , 'Obama '      ,   '1776-07-04' ,  22000  ,  ' [346} 604-1234'  , 'mich@yahoo.com'        , 5 ) ; " ) ;

session.Execute(" iNSeRT INto members ( id , first_name , last_name , sign_up , points , phone , e_mail , store_no )   ValueS ( uuid() , 'Mario '      , 'Lopez '      ,   '2025-03-16' ,  55     ,  ' [281} 135-2468'  , 'mario@savedbell.com'   , 8 ) ; " ) ;

session.Execute(" iNSeRT INto members ( id , first_name , last_name , sign_up , points , phone , e_mail , store_no )   ValueS ( uuid() , 'Jackie '     , 'Chan'        ,   '2025-02-14' ,  2000   ,  ' [713} 111-9999'  , 'chan@rushhour.com'     , 4 ) ; " ) ;

session.Execute(" iNSeRT INto members ( id , first_name , last_name , sign_up , points , phone , e_mail , store_no )   ValueS ( uuid() , 'Denzel '     , 'Washington ' ,   '1773-12-16' ,  100    ,  ' [255} 333-1212'  , 'denzel@hurricane.com'  , 3 ) ; " ) ;

session.Execute(" iNSeRT INto members ( id , first_name , last_name , sign_up , points , phone , e_mail , store_no )   ValueS ( uuid() , 'Tom '        , 'Hanks '      ,   '1862-03-10' ,  200    ,  ' [522} 656-7777'  , 'tom@big.com'           , 4 ) ; " ) ;

session.Execute(" iNSeRT INto members ( id , first_name , last_name , sign_up , points , phone , e_mail , store_no )   ValueS ( uuid() , 'Nicole '     , 'Kidman '     ,   '1997-07-04' ,  300    ,  ' [366} 123-4567'  , 'nicole@others.com'     , 5 ) ; " ) ;

session.Execute(" iNSeRT INto members ( id , first_name , last_name , sign_up , points , phone , e_mail , store_no )   ValueS ( uuid() , 'Julia '      , 'Roberts '    ,   '1620-12-11' ,  400    ,  ' [633} 765-4321'  , 'julia@oceans.com'      , 6 ) ; " ) ;

session.Execute(" iNSeRT INto members ( id , first_name , last_name , sign_up , points , phone , e_mail , store_no )   ValueS ( uuid() , 'Reese '     , 'Witherspoon ' ,   '1941-12-07' ,  500    ,  ' [111} 888-0000'  , 'reese@blonde.com'      , 8 ) ; " ) ;




      //      PRODUCTS

session.Execute(" iNSeRT INto products ( id , name , category , price , quantity  , store_no , phone , street , city , zip )   ValueS ( uuid() , 'Nintendo Switch 2'       ,    'console' , 449.99 , 50  , 3 , '{713] 999 - 0000' , 'One Main' , 'Houston' , 77002  ) ; " ) ;

session.Execute(" iNSeRT INto products ( id , name , category , price , quantity  , store_no , phone , street , city , zip )   ValueS ( uuid() , 'street fighter 2'        ,    'video game' , 29.99 , 20  , 8 , '{713] 643 - 9070' , '770 GulFgate' , 'Dallas' , 77087  ) ; " ) ;

session.Execute(" iNSeRT INto products ( id , name , category , price , quantity  , store_no , phone , street , city , zip )   ValueS ( uuid() , 'black wireless'             ,    'controller' , 179.99 , 30  , 5 , '{713] 385 - 6789' , '2525 Wayside' , 'Austin' , 77032 ) ; " ) ;

session.Execute(" iNSeRT INto products ( id , name , category , price , quantity  , store_no , phone , street , city , zip )   ValueS ( uuid() , 'Yu-Gi-Oh!'                  ,    'trading card' , 250 , 50  , 3 , '{281] 123 - 2468' , '777 Hollywood' , 'San Antonio' , 77055  ) ; " ) ;

session.Execute(" iNSeRT INto products ( id , name , category , price , quantity  , store_no , phone , street , city , zip )   ValueS ( uuid() , 'Batman'                     ,    'collectble' , 24.99 , 1  , 6 , '{281] 123 - 1357' , '999 MLK' , 'Houston' , 77021  ) ; ");

session.Execute(" iNSeRT INto products ( id , name , category , price , quantity  , store_no , phone , street , city , zip )   ValueS ( uuid() , 'Playstation 5'              ,    'console' , 449.99 , 25  , 4 , '{281] 123 - 2468' , '777 Hollywood' , 'San Antonio' , 77055  ) ; " ) ;

session.Execute(" iNSeRT INto products ( id , name , category , price , quantity  , store_no , phone , street , city , zip )   ValueS ( uuid() , 'Racing Wheel'               ,    'accessories' , 329.99 , 6  , 3 , '{281] 123 - 1357' , '999 MLK' , 'Houston' , 77021  ) ; " ) ;

session.Execute(" iNSeRT INto products ( id , name , category , price , quantity  , store_no , phone , street , city , zip )   ValueS ( uuid() , 'Nintendo eShop'            ,    'gift cards', 70.00 , 100  , 8 , '{713] 643 - 9070' , '770 GulfGate' , 'Dallas' , 77087  ) ; " ) ;

session.Execute(" iNSeRT INto products ( id , name , category , price , quantity  , store_no , phone , street , city , zip )   ValueS ( uuid() , 'Indiana Jones & the O' ,    'game' , 69.99 , 40  , 5 , '{713] 385 - 6789' , '2525 Wayside' , 'Austin' , 77032  ) ; " ) ;

session.Execute(" iNSeRT INto products ( id , name , category , price , quantity  , store_no , phone , street , city , zip )   ValueS ( uuid() , 'xBox Series X'           ,   'console' , 499.99 , 25  , 3 , '{281] 123 - 2468' , '777 Hollywood' , 'San Antonio' , 77055  ) ; " ) ;




//      SALES

session.Execute(" iNSeRT INto sales ( id , date_time , pay  , total , member , employee  )   ValueS ( uuid() , toTimestamp(now()) , 'cash'  , 111.11 , uuid() , uuid()  ) ; " ) ;

session.Execute(" iNSeRT INto sales ( id , date_time , pay  , total , member , employee  )   ValueS ( uuid() , toTimestamp(now()) , 'gift' , 40.05 , uuid() , uuid()  ) ; " ) ;
    
session.Execute(" iNSeRT INto sales ( id , date_time , pay  , total , member , employee  )   ValueS ( uuid() , toTimestamp(now()) , 'debit' , 556.92 , uuid() , uuid()  ) ; " ) ;

session.Execute(" iNSeRT INto sales ( id , date_time , pay  , total , member , employee  )   ValueS ( uuid() , toTimestamp(now()) , 'cash' , 50 , uuid() , uuid()  ) ; " ) ;

session.Execute(" iNSeRT INto sales ( id , date_time , pay  , total , member , employee  )   ValueS ( uuid() , toTimestamp(now()) , 'debit' , 999 , uuid() , uuid()  ) ; " ) ;

session.Execute(" iNSeRT INto sales ( id , date_time , pay  , total , member , employee  )   ValueS ( uuid() , toTimestamp(now()) , 'combo' , 69.99 , uuid() , uuid()  ) ; " ) ;

session.Execute(" iNSeRT INto sales ( id , date_time , pay  , total , member , employee  )   ValueS ( uuid() , toTimestamp(now()) , 'credit' , 999.97 , uuid() , uuid()  ) ; " ) ;

session.Execute(" iNSeRT INto sales ( id , date_time , pay  , total , member , employee  )   ValueS ( uuid() , toTimestamp(now()) , 'credit' , 119.98 , uuid() , uuid()  ) ; " ) ;

session.Execute(" iNSeRT INto sales ( id , date_time , pay  , total , member , employee  )   ValueS ( uuid() , toTimestamp(now()) , 'combo' , 449.99 , uuid() , uuid()  ) ; " ) ;

session.Execute(" iNSeRT INto sales ( id , date_time , pay  , total , member , employee  )   ValueS ( uuid() , toTimestamp(now()) , 'cash' , 70 , uuid() , uuid()  ) ; " ) ;



   

 
Console.WriteLine("\nComplete ");


 Console.ReadKey();