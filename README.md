# Team_Necropolis_OOP_2015
Team work of Necropolis for OOP 2015 of Telerik Academy

##Our project will be TODO app
####What the app should have(not final)
+ add note(name, comment)
+ add todo(name, comment, due date, date reminder)
+ add repeating todo (todo + set of repeating dates & reminders maybe)
+ add shared todo (todo with user name)
+ add todo with subtasks (set of todos)
+ add todo with attached file/picture (?)
+ add priority to todo (1-5)
+ add access level to todos for one user - private/public/(only friends?)
+ add Project Personal/Work/Dog/Errants/Shop etc. where we will store several todos
+ add label to todos
+ browse/show todos:
  * today, tomorrow, next 7 days, someday todos, notes
+ remove/done/ todo
+ notifications option for todo
+ reminder for todo
+ sorting todos by priority/date/tag/alphabetically

####Users (process in work)
+ abstract class person - with, f&l name, date birth, position (student, employee, employee herarcity in company)
+ add user
+ add boss
+ add premium user
+ add client
####Design
+ Color tags

####Extras

* * *

#####Exmple classes
#####User
User name, Password, Boards
######functions:
#####Board - custom boards for list of todo's and notes ex. Today, Work, Private, Whishlist
todos, notes at the end
######functions:
#####Note
Title, text, tag, DateTime created
######functions:
#####todo : Note 
due DateTime
######functions:
#####todo reminder : todo 
time  before the event
######functions:
#####todo check : todo
checklist
######functions:
