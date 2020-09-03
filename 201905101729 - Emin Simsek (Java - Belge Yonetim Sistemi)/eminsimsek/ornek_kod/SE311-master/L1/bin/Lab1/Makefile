#variable declaration
JAVA = java
JAR = jar
JC = javac
FLAGS = cp
VIEWER = more
DOCS = javadoc


FILES = Filter.java \
	Pipe.java \
	PipeImpl.java \
	UpperCaseMain.java


MAIN = UpperCaseMain

.PHONY: run view clean

#run and execute program
run:
	@$(JC) $(FILES) -Xlint:unchecked 
	$(JAVA) $(MAIN)

#view source code
view:
	$(VIEWER) README $(FILES)

clean:
	@rm *.class
	@echo Done.%
