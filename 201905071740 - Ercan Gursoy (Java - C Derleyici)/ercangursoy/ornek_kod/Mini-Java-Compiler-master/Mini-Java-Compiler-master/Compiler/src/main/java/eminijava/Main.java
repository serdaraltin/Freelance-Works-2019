package eminijava;

import java.io.File;
import java.io.FileReader;
import java.io.PrintWriter;

import eminijava.ast.ASTPrinter;
import eminijava.ast.Program;
import eminijava.ast.Tree;
import eminijava.lexer.JSymbol;
import eminijava.lexer.Lexer;
import eminijava.lexer.Token;
import eminijava.parser.ParseException;
import eminijava.parser.Parser;
import eminijava.semantics.NameError;
import eminijava.semantics.SemanticErrors;
import eminijava.symbol.SymbolTable;
import eminijava.visitor.BranchGenerator;
import eminijava.visitor.BuildSymbolTableVisitor;
import eminijava.visitor.CodeGenerator;
import eminijava.visitor.CodeGenerator2;
import eminijava.visitor.ConstantFolding;
import eminijava.visitor.NameAnalyserTreeVisitor;
import eminijava.visitor.StatementFolding;
import eminijava.visitor.TreePrinter;
import eminijava.visitor.TypeAnalyser;

public class Main {

	public static void main(String argv[]) {

		Main main = new Main();

		if (argv.length < 2) {
			System.err.println("USAGE: java eminijava.Main <OPTION> <FILENAME>");
			System.exit(1);
		}

		switch (argv[0]) {
		case "--lex": {
			main.lex(argv);
		}
			break;
		case "--ast": {
			main.parse(argv);
		}
			break;
		case "--name": {
			main.nameAnalysis(argv);
		}
			break;

		case "--pp": {
			main.prettyPrint(argv);
		}
			break;

		case "--type": {
			main.typeAnalysis(argv);
		}
			break;
		case "--cgen": {
			main.codeGen(argv);
		}
			break;
		case "--opt": {
			main.optCodeGen(argv);
		}
			break;

		case "--optinfo": {
			main.optinfo(argv);
		}
			break;
		default: {
			System.err.println("Invalid option " + argv[0]);
		}

		}

	}

	public void optinfo(String argv[]) {
		for (int i = 1; i < argv.length; i++) {
			try {

				if (!isFileValid(argv[i])) {
					continue;
				}

				Lexer lexer = new Lexer(new FileReader(argv[i]));
				Parser p = new Parser(lexer);
				Tree tree = p.parse();

				if (tree != null) {
					BuildSymbolTableVisitor bstv = new BuildSymbolTableVisitor();
					bstv.visit((Program) tree);

					SymbolTable st = bstv.getSymTab();
					NameAnalyserTreeVisitor natv = new NameAnalyserTreeVisitor(st);
					natv.visit((Program) tree);

					TypeAnalyser ta = new TypeAnalyser(st);
					ta.visit((Program) tree);

					if (SemanticErrors.errorList.size() == 0) {

						String path = getFileDirPath(argv[i]);
						CodeGenerator cg = new CodeGenerator(path);
						cg.visit((Program) tree);
						int len = cg.getLen();

						ConstantFolding.optimize(tree);
						StatementFolding.optimize(tree);
						CodeGenerator2 optCg = new CodeGenerator2(path);
						BranchGenerator bg = new BranchGenerator(optCg);
						optCg.setBG(bg);
						optCg.visit((Program) tree);
						int optLen = optCg.getLen();
						optLen += bg.getLen();

						System.out.println("#bytecode before optimization: " + len);
						System.out.println("#bytecode after optimization: " + optLen);
					}
				}
			} catch (ParseException e) {
				System.err.println(e.getMessage());
				System.exit(1);
			} catch (Exception e) {
				e.printStackTrace();
				System.exit(1);
			} finally {
				if (SemanticErrors.errorList.size() != 0) {
					SemanticErrors.sort();
					for (NameError e : SemanticErrors.errorList) {
						System.err.println(e);
					}
				}
			}
		}
	}

	public void optCodeGen(String argv[]) {
		for (int i = 1; i < argv.length; i++) {
			try {

				if (!isFileValid(argv[i])) {
					continue;
				}

				Lexer lexer = new Lexer(new FileReader(argv[i]));
				Parser p = new Parser(lexer);
				Tree tree = p.parse();

				if (tree != null) {
					BuildSymbolTableVisitor bstv = new BuildSymbolTableVisitor();
					bstv.visit((Program) tree);

					SymbolTable st = bstv.getSymTab();
					NameAnalyserTreeVisitor natv = new NameAnalyserTreeVisitor(st);
					natv.visit((Program) tree);

					TypeAnalyser ta = new TypeAnalyser(st);
					ta.visit((Program) tree);

					ConstantFolding.optimize(tree);
					StatementFolding.optimize(tree);

					if (SemanticErrors.errorList.size() == 0) {
						String path = getFileDirPath(argv[i]);
						CodeGenerator2 cg = new CodeGenerator2(path);
						BranchGenerator bg = new BranchGenerator(cg);
						cg.setBG(bg);
						cg.visit((Program) tree);
					}
				}
			} catch (ParseException e) {
				System.err.println(e.getMessage());
				System.exit(1);
			} catch (Exception e) {
				e.printStackTrace();
				System.exit(1);
			} finally {
				if (SemanticErrors.errorList.size() != 0) {
					SemanticErrors.sort();
					for (NameError e : SemanticErrors.errorList) {
						System.err.println(e);
					}
				}
			}
		}
	}

	public void codeGen(String argv[]) {
		for (int i = 1; i < argv.length; i++) {
			try {

				if (!isFileValid(argv[i])) {
					continue;
				}

				Lexer lexer = new Lexer(new FileReader(argv[i]));
				Parser p = new Parser(lexer);
				Tree tree = p.parse();

				if (tree != null) {
					BuildSymbolTableVisitor bstv = new BuildSymbolTableVisitor();
					bstv.visit((Program) tree);

					SymbolTable st = bstv.getSymTab();
					NameAnalyserTreeVisitor natv = new NameAnalyserTreeVisitor(st);
					natv.visit((Program) tree);

					TypeAnalyser ta = new TypeAnalyser(st);
					ta.visit((Program) tree);
					if (SemanticErrors.errorList.size() == 0) {
						String path = getFileDirPath(argv[i]);
						CodeGenerator cg = new CodeGenerator(path);
						cg.visit((Program) tree);
					}
				}
			} catch (ParseException e) {
				System.err.println(e.getMessage());
				System.exit(1);
			} catch (Exception e) {
				e.printStackTrace();
				System.exit(1);
			} finally {
				if (SemanticErrors.errorList.size() != 0) {
					SemanticErrors.sort();
					for (NameError e : SemanticErrors.errorList) {
						System.err.println(e);
					}
				}
			}
		}
	}

	public void typeAnalysis(String argv[]) {
		for (int i = 1; i < argv.length; i++) {
			try {

				if (!isFileValid(argv[i])) {
					continue;
				}

				Lexer lexer = new Lexer(new FileReader(argv[i]));
				Parser p = new Parser(lexer);
				Tree tree = p.parse();

				if (tree != null) {
					BuildSymbolTableVisitor bstv = new BuildSymbolTableVisitor();
					bstv.visit((Program) tree);

					SymbolTable st = bstv.getSymTab();
					NameAnalyserTreeVisitor natv = new NameAnalyserTreeVisitor(st);
					natv.visit((Program) tree);

					TypeAnalyser ta = new TypeAnalyser(st);
					ta.visit((Program) tree);
					if (SemanticErrors.errorList.size() == 0) {
						System.out.println("Valid eMiniJava Program");
					}
				}
			} catch (ParseException e) {
				System.err.println(e.getMessage());
				System.exit(1);
			} catch (Exception e) {
				e.printStackTrace();
				System.exit(1);
			} finally {
				if (SemanticErrors.errorList.size() != 0) {
					SemanticErrors.sort();
					for (NameError e : SemanticErrors.errorList) {
						System.err.println(e);
					}
				}
			}
		}
	}

	public void prettyPrint(String argv[]) {
		for (int i = 1; i < argv.length; i++) {
			try {

				if (!isFileValid(argv[i])) {
					continue;
				}

				Lexer lexer = new Lexer(new FileReader(argv[i]));
				Parser p = new Parser(lexer);
				Tree tree = p.parse();

				if (tree != null) {
					BuildSymbolTableVisitor bstv = new BuildSymbolTableVisitor();
					bstv.visit((Program) tree);

					SymbolTable st = bstv.getSymTab();
					NameAnalyserTreeVisitor natv = new NameAnalyserTreeVisitor(st);
					natv.visit((Program) tree);

					TreePrinter pp = new TreePrinter();
					String s = pp.visit((Program) tree);
					System.out.println(s);
				}
			} catch (ParseException e) {
				System.err.println(e.getMessage());
				System.exit(1);
			} catch (Exception e) {
				e.printStackTrace();
				System.exit(1);
			}
		}
	}

	public void nameAnalysis(String argv[]) {
		for (int i = 1; i < argv.length; i++) {
			try {

				if (!isFileValid(argv[i])) {
					continue;
				}

				Lexer lexer = new Lexer(new FileReader(argv[i]));
				Parser p = new Parser(lexer);
				Tree tree = p.parse();

				if (tree != null) {
					BuildSymbolTableVisitor bstv = new BuildSymbolTableVisitor();
					bstv.visit((Program) tree);

					SymbolTable st = bstv.getSymTab();
					NameAnalyserTreeVisitor natv = new NameAnalyserTreeVisitor(st);
					natv.visit((Program) tree);

					if (SemanticErrors.errorList.size() == 0) {
						System.out.println("Valid eMiniJava Program");
					}
				}

			} catch (ParseException e) {
				System.err.println(e.getMessage());
				System.exit(1);
			} catch (Exception e) {
				e.printStackTrace();
				System.exit(1);
			} finally {
				if (SemanticErrors.errorList.size() != 0) {
					SemanticErrors.sort();
					for (NameError e : SemanticErrors.errorList) {
						System.err.println(e);
					}
				}
			}

		}
	}

	public void parse(String argv[]) {
		ASTPrinter printer = new ASTPrinter();
		for (int i = 1; i < argv.length; i++) {
			try {

				if (!isFileValid(argv[i])) {
					continue;
				}

				System.out.println("Parsing file [" + argv[i] + "]");

				Lexer lexer = new Lexer(new FileReader(argv[i]));
				Parser p = new Parser(lexer);
				Tree tree = p.parse();
				if (tree != null) {
					String sexpr = printer.visit((Program) tree);
					PrintWriter writer = new PrintWriter(getFileName(argv[i]) + ".ast", "UTF-8");
					writer.println(sexpr);
					writer.close();
					System.out.println("Generated output file");
				}

			} catch (ParseException e) {
				System.err.println(e.getMessage());
				System.exit(1);
			} catch (Exception e) {
				e.printStackTrace();
				System.exit(1);
			}
		}
	}

	public void lex(String[] argv) {

		for (int i = 1; i < argv.length; i++) {

			try {

				if (!isFileValid(argv[i])) {
					continue;
				}

				System.out.println("Lexing file [" + argv[i] + "]");
				Lexer lexer = new Lexer(new FileReader(argv[i]));
				PrintWriter writer = new PrintWriter(getFileName(argv[i]) + ".lexed", "UTF-8");

				JSymbol s;
				do {
					s = lexer.yylex();
					writer.println(s);
				} while (s.token != Token.EOF);

				writer.close();
			} catch (Exception e) {
				e.printStackTrace(System.out);
				System.exit(1);
			}
			System.out.println("Generated output file");
		}

	}

	private boolean isFileValid(String filename) {
		File f = new File(filename);

		if (!f.exists()) {
			System.err.println(filename + ": No such file!");
			return false;
		}

		String fileExtension = getFileExtension(f);
		if (!"emj".equals(fileExtension)) {
			System.err.println(filename + ": Invalid file extension!");
			return false;
		}

		return true;
	}

	private String getFileExtension(File file) {
		String name = file.getName();
		try {
			return name.substring(name.lastIndexOf(".") + 1);
		} catch (Exception e) {
			return "";
		}
	}

	private String getFileName(String filename) {
		try {
			return filename.substring(0, filename.lastIndexOf("."));
		} catch (Exception e) {
			return "";
		}
	}

	private String getFileDirPath(String filename) {
		try {
			File f = new File(filename);
			String path = f.getParent();
			if (path == null) {
				return "";
			}
			return path + File.separator;
		} catch (Exception e) {
			return "";
		}
	}

}
