# Team_Necropolis_OOP_2015
Team work of Necropolis for OOP 2015 of Telerik Academy

##Our project will be COMPANY TODO app
###Plan
####Users - Иван
+ Human - name, date birth, sex, age (abstract class maybe)
+ Employee - + position, salary, time worked (inheritors)
+ Manager positon=manager(?) (inheritor)
  * his team employees, can assing/edit todos of his team?
  * can see progress of his team members 
+ Boss - + positon=boss (inheritor)
  * can asign/edit every todo of employees
  * can see progress of every todo/project
+  Client - name, his company, his project todo, give todos/task to boss/manager(?) (this cant be inherited i think)
  * client may be IClientable for User class / or something like that
+ stajanti maybe
  
**We can add interfaces for:**
+ if the user is subordinate (employee, manager) - eg. ISubordinate
+ if the user have people who he manage (manager/ boss) - eg. IManaging (?)

_maybe only boss can make new users(and new clients) (like hiring) maybe also managers can hire_
_also when user is done with task, there will be point for him, to show how much work he/she have done and will be saved to his profile_
  
_there should be option in their profile to see in which projects the collaborate_

###Todos/tasks/projects etc. - Генко
+ Coment (maybe abstract)
+ Note (name, coment) (inherit)
+ Todo(name, coment, date due, reminder*) (inherit)
+ Repeating Todo(name, coment, dates for repeat, reminders*) (inherit?)
+ Shared Substasked Todo(name, coment, due date, reminder, subtasks, sharing wirh username)
  * (i think not inheriting bc there is set of todos/subtasks)

**also every todo must have a option to see who assigned it (and to who maybe) (maybe something like history boss to manager, manager to employee, or maybe not idk)**

*i think it will be nice for every task/todo/project to say if its public project or private something like that*
  
__*optional__
  
_option % of the task/project is done_

###Functions
1. Create new User / delete(?)
  * for every user:
   * can make new projects(w/o employees maybe or stajanti), todos, notes, assign todo/projects if have the rights
   * every user can see public todos of company, 
   * boss can see every task, 
   * manager every one of his team, but not of other managers if they are private;
2. Sorting
  * show users by date hired, age, name, sex, points etc...
  * todos can be sorted by date, name, priority, public, private, procent done...
  * boss can see todos in new window for every user and their profile, the same for managers
  * for every project we can see who is part of it, and maybe everyone of the team how much have done
3. Assinging projects/todos
  * boss and managers can assign them to employees, + employees to stajanti

4. Also
  * Asigned todo/project with todos (...., username of who assigned, username to who assigned) 

####Design
+ Color tags

####Progress of requirements

+ At least 5 interfaces (with one or more implementations) - **done**
+ At least 15 classes (implementing the application logic) **done**
+ At least 3 abstract classes (with inheritors) **done**
	1. Peson
	2. Todo
	3. Common Validator
+ At least 1 custom exception class (with usage in your code) **done**
+ At least 3 levels of depth in inheritance **done**
+ At least 1 polymorphism usage
+ At least 1 structure
+ At least 1 enumeration **done**
+ At least 1 event (with subscribers) **done**
+ At least 1 design pattern **done**


