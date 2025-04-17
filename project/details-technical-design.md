[< Back to Project Overview](README.md#technical-design)

# Technical Design Instructions and Rubric

At this point, you have spent significant time thinking about and working on your project. You should have very good ideas how to implement your system. Now that you have this knowledge and insight, you will produce a technical design detailing how you will build the most critical pieces of the system.

### Requirements

1.  [Start by carefully reading the Technical Design phase of the project.](README.md#technical-design)

2.  Produce all documentation in Markdown and integrate it into your team GitHub project repository so it is easily found and read. Make sure you write a short introduction to the technical design.

3.  Your Technical Design includes the following 8 deliverables in your Technical Design section:

    1.  **Implementation Language(s) and Framework(s)** (2 sub-sections)

        1.  **Implementation Language(s) including \*why\* you selected it** *For example, if you are using Grails, your languages are Groovy and HTML. JavaFX is not a language - it's a framework that uses Java. As always, write using bullets, lists, and tables... avoid huge paragraphs. Include links to your language's documentation, useful tutorials, etc. Your goal here is to help a developer understand why you choose the language and quickly learn more about it.**
        2.  ***Implementation Frameworks including \*why\* selected them** *For example, if you are using Grails, the framework is Grails. You might also use a CSS framework such as Bootstrap. JavaFX is a framework. Blazor is a framework that uses the C# language. Include useful links to documentation for your framework(s). You goal here is to help a developer understand your architecture and quickly learn more about it. Links to tutorials and videos are quite useful as well. As always, write using bullets, lists, and tables... avoid huge paragraphs.**

    2.  ***Entity Relationship Diagram, Entity/Field Descriptions and Data Examples** (4 sub-sections)
        *All of the data your system manages and how each data type is related will be visually depicted here. Your ERD design is not an academic effort - this should match what you actually plan to implement - so plan carefully keeping in mind the data your user interface design demonstrated the application will display/manage.*

        -  **Entity Relationship Diagram** *Show every entity using Crows Foot notation, fields in the entity, plus the relationships and multiplicity.* I recommend drawing this in [PlantUML](https://www.plantuml.com/plantuml/svg/bLBDRXen4BxlKumu8YB1ePUSaZHfXTgcbFG531wbbhmUDBOfgy2xTx1nT-coHRdP_dxqpJU-yq5nYBMjq0KJ6hZt7hslvRR4hV667BnL0EDn7vZhyVWM5b_0k301exD3TQYArqzJ8v_awNnKm0K9m2NtM_YKY0A_KEGrphM8juhNlnJ3R3eLu5dLs7jyZAo2MBpWcfpsWcUNfzt6PEI1TDEgQhKxGv_Lrhpc4-x2LxL2sv8_JAlEY1_91Jb-PegRDAcCsdqRw0YkJWmBHYzWYl6TDNAPucyP_uuDAMdlzH7zcitcwDF5CZZtItnoWPjxQ-atYkUAo0gIbzT6ce2BrggLnKdM9NoXeY-YIKvDhonpFIWUZFaZea_bndg5mxIKwDJbt2rnGnpyAL-xW69MoY_tmUAlzNw-lIvoxLkSKHOixXJzvT_J3m6ZsGZs-viRUeFH50B1D-MQKLx3__XxuSzQVZV-EsIbjgghJ-G32Nb_p4GCinAeHsizbTD0pZP2RctlqEbOspy0) or [Mermaid](https://mermaid.live/edit#pako:eNp1Uk1vwjAM_StWdtkk-AHtreJDmhgFFdhh6w5ea9qINqmcsIkB_30p7bSVjlziOM_2e7aPItEpCV8QjyVmjGWswJ1REMHpNBzqI4TBfDIejqPH50kEPmBR6E_zizo2Zn2MZakyYMqkM9FKrcJ9-U4My1kPVeKO-k5Hprj2vr5BhWzbmufmWk6i1SK8wVGaDqhPMWX5QWyeZELKkKMHsVjnBEXruIvFdcy95z3AVrKxIZbk8AtVHMDzIMmRMbEuHSBT0x9K-wmgwCa291HlWhFs_vRIKguYUUdxR2NfUoIc_df4AUxnN_Rf5CfUAbXF5kG4mQaj9SZyxXSttKZoNXwRa9DsJuW01vP3L5M0YiBK4hJl6pbpwi4WNienVvjOTJF3dUvODod7q1cHlQjf8p4GYl-laKldvx9nhepFa_fcYmHo_A0pm9Hm). Do *not* draw your ERD using [Chen Notation](https://vertabelo.com/blog/chen-erd-notation/). You must use [Crows Foot Notation](https://www.freecodecamp.org/news/crows-foot-notation-relationship-symbols-and-how-to-read-diagrams/), 

        -  **Table of Field Descriptions for each entity** *List and describe every field of every entity and the data type. Include data type sizes you are using SQL (for example, nvarchar 50 is a 50 character Unicode string in SQL Server.) Note whether the field is required or nullable (can be empty). If the field is a key, note if it is a primary or foreign key. If the key is a foreign key, note the origin table of the value. 

        -  **Example Data** *For each entity in your entity relationship diagram, create a table showing 3-5 sample records. Make sure they follow your data types described in the Table of Field Descriptions and are properly related to one another if there are foreign keys to other entities. Your goal here is to ensure a developer reading your entity design plan can see realistic examples of the types of data and how they related to one another.* 
        -  **Database Seed Data**
           When you start your application, what is *already* in the system? [We call this "seed data"](https://en.wikipedia.org/wiki/Database_seeding). Typically that includes at least one administrator account, your inventory items and photos, etc. This is *not* the same as example data. This is actual data your application requires to simply start the first time and will be present in your implementation. *Create a table describing your seed data for each entity that will contain data when the application starts.

    4.  **Data Storage Plan**
        How will your application store data? Your choices are CSV, JSON, and SQL. Describe the libraries and technologies you will use to store data. For example, if you are using C#, you might use Dapper or Entity Framework for data access to write to an embedded SQLite database. If you are using Java, you might use a JDBC driver to access a Postgres database. Write this as a series of steps or bullet points. Avoid large long dull paragraphs. *Remember that the data you change/add **must remain available the next time you start the application** - this is a class project, but it needs to operate like a real application - starting fresh every time you launch the application is not realistic. Therefore, you must have persistent data storage - not just memory storage. As always, write using bullets, lists, and tables... avoid huge paragraphs.*

    5.  [**Coding Style Guide**](https://www.cs.cornell.edu/courses/JavaAndDS/JavaStyle.html)
        *Here you will link to your language's coding style guide, plus add any coding style instructions you expect all developers to follow. A common feature of a coding style guide is source control management, such as use of git and perhaps a branch management strategy such as [GitFlow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow#:~:text=What is Gitflow%3F,lived branches and larger commits.) The ultimate goal is that all code follows a consistent style and appears to have been written by one person. Think about what will help future developers will need to understand your system, including commenting guidelines, naming conventions, filename conventions, etc. As always, write using bullets, lists, and tables... avoid huge paragraphs.

### Submission Steps

The entire team will work execute the technical design EFFORT. *All of you need* to review the completed work. This is a team effort and the team will succeed or fail as a group.

Technical design is critical to the success of your project. Be very careful here and strive for accuracy and outstanding communication technique.

Once your work is complete, add a section called Technical Design to your project's main README.md file that links to your technical design documentation.

### Grading Rubric

#### Component Percentages

1.  Implementation Language(s) and Framework(s) (2 sections) - 20%
2.  Entity Design (4 sections) - 35%
3.  Data Storage Plan - 12.5%
4.  Coding Style Guide - 12.5%
5.  3-5 minute video presentation describing your plan, technology selection and team assignments (Github) - 20%

#### Implementation Language(s) and Framework(s) (20% of total)

-  90 to 100%: meets all requirements, well-written well organized, and highly professional. Polished work gets the top grade.
-  80% to 89%: meets all requirements, may have some writing or organizational issues.
-  70% to 79%: meets most requirements, may have some writing or organizational issues.
-  69% or below: does not meet most requirements or is very poorly written.

*Note: Written work not posted to Github using Markdown will not be graded.*

#### Entity Design (35% of total)

-  90 to 100%: meets all requirements, well-written well organized, and highly professional. Polished work gets the top grade.
-  80% to 89%: meets all requirements, may have some minor graphical issues or organizational issues.
-  70% to 79%: meets most requirements, may have some minor graphical or organizational issues.
-  69% or below: does not meet most requirements or is very poorly drawn or contains incorrect information.

*Note: Documentation and diagrams not posted to Github and linked to your Markdown will not be graded.*

#### Data Storage Plan (12.5% of total)

-  90 to 100%: meets all requirements, well-written well organized, and highly professional. Polished work gets the top grade.
-  80% to 89%: meets all requirements, may have some minor graphical issues or organizational issues.
-  70% to 79%: meets most requirements, may have some minor graphical or organizational issues.
-  69% or below: does not meet most requirements or is very poorly drawn or contains incorrect information.

*Note: Documentation not posted to Github and linked to your Markdown will not be graded.*

#### Coding Style Guide (12.5% of total)

-  90 to 100%: meets all requirements, well-written well organized, and highly professional. Polished work gets the top grade.
-  80% to 89%: meets all requirements, may have some minor graphical issues or organizational issues.
-  70% to 79%: meets most requirements, may have some minor graphical or organizational issues.
-  69% or below: does not meet most requirements or is very poorly drawn or contains incorrect information.

*Note: Documentation not posted to Github and linked to your Markdown will not be graded.*

#### Presentation Scoring (20% total)

*Do not just read requirements!*

-  90% to 100%: meets all requirements, well-organized, easy to follow audio. Polished work gets the top grade.
-  80% to 89%: meets all requirements, easy to follow audio, may have some organization issues.
-  70% to 79%: meets most requirements, may have some organization or audio issues.
-  69% or below: does not meet most requirements or has little or no audio.

*Note: Presentations not posted to Github will not be graded.*

### Academic Honesty

Your work must be your own. Do not plagiarize under any circumstances. All work is subject to review by TurnItIn, etc.

More importantly, this course is a waste of your time if you do not do the work yourself. If you are tempted to cheat, you need to ask yourself why you are here and what you hope to accomplish in your career if you get the grade, but have minimal ability to perform the work after you leave the University.

### Team Grading

Everyone on the team will receive the same grade with one exception. It follows.

Anyone not participating in the project may be removed from the team and have to perform the project alone. Before anyone can be "fired" from a team, I must meet with the *entire team* and hear what is happening. Do not fire anyone from your team without my explicit prior agreement.

---

[< Back to Project Overview](README.md#technical-design)
