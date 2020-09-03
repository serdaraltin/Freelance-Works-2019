#variable declaration
JAVA = java
JAR = jar
JC = javac
FLAGS = cp
VIEWER = more
DOCS = javadoc


FILES = Client.java \
	File.java \
	FileSystem.java \
	Folder.java \
	PrintVisitor.java \
	ReportVisitor.java \
	SortVisitor.java \
	Visitor.java 


MAIN = Client

.PHONY: run view clean

#run and execute program
run:
	@$(JC) $(FILES)
	$(JAVA) $(MAIN)


#view source code
view:
	$(VIEWER) README $(FILES)

clean:
	@rm *.class
	@echo Done.
