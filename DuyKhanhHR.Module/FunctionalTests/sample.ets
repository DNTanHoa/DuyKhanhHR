;#DropDB DuyKhanhHREasyTest

#Application DuyKhanhHR.Win
#Application DuyKhanhHR.Web

*FillForm
 User Name = Admin
*Action Log In

#IfDef DuyKhanhHR.Win

*Action About...
 
*Action OK

#EndIf

#IfDef DuyKhanhHR.Web
*Action Navigation(My Details)
#EndIf
