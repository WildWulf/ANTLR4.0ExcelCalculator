//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Administrator\source\repos\OOPFirstLab\OOPFirstLab\ANTLR\ExcelCalculator.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace OOPFirstLab.ANTLR {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class ExcelCalculatorParser : Parser {
	public const int
		T__0=1, NUMBER=2, INT=3, IDENTIFIER=4, NOT=5, AND=6, OR=7, EQUALLITYDIGIT=8, 
		MOREDIGIT=9, LESSDIGIT=10, MOD=11, DIV=12, MULTIPLY=13, DIVIDE=14, ADD=15, 
		SUBTRACT=16, LPAREN=17, RPAREN=18, WS=19;
	public const int
		RULE_compileUnit = 0, RULE_expression = 1;
	public static readonly string[] ruleNames = {
		"compileUnit", "expression"
	};

	private static readonly string[] _LiteralNames = {
		null, "','", null, null, null, "'not'", "'and'", "'or'", "'='", "'>'", 
		"'<'", "'mod'", "'div'", "'*'", "'/'", "'+'", "'-'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "NUMBER", "INT", "IDENTIFIER", "NOT", "AND", "OR", "EQUALLITYDIGIT", 
		"MOREDIGIT", "LESSDIGIT", "MOD", "DIV", "MULTIPLY", "DIVIDE", "ADD", "SUBTRACT", 
		"LPAREN", "RPAREN", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ExcelCalculator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public ExcelCalculatorParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class CompileUnitContext : ParserRuleContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(ExcelCalculatorParser.Eof, 0); }
		public CompileUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compileUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.EnterCompileUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.ExitCompileUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExcelCalculatorVisitor<TResult> typedVisitor = visitor as IExcelCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompileUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompileUnitContext compileUnit() {
		CompileUnitContext _localctx = new CompileUnitContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_compileUnit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 4; expression(0);
			State = 5; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class MultiplicativeExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode MULTIPLY() { return GetToken(ExcelCalculatorParser.MULTIPLY, 0); }
		public ITerminalNode DIVIDE() { return GetToken(ExcelCalculatorParser.DIVIDE, 0); }
		public MultiplicativeExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.EnterMultiplicativeExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.ExitMultiplicativeExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExcelCalculatorVisitor<TResult> typedVisitor = visitor as IExcelCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultiplicativeExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NotFunctionExprContext : ExpressionContext {
		public IToken operatorToken;
		public ITerminalNode LPAREN() { return GetToken(ExcelCalculatorParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ExcelCalculatorParser.RPAREN, 0); }
		public ITerminalNode NOT() { return GetToken(ExcelCalculatorParser.NOT, 0); }
		public NotFunctionExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.EnterNotFunctionExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.ExitNotFunctionExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExcelCalculatorVisitor<TResult> typedVisitor = visitor as IExcelCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNotFunctionExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AdditiveExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode ADD() { return GetToken(ExcelCalculatorParser.ADD, 0); }
		public ITerminalNode SUBTRACT() { return GetToken(ExcelCalculatorParser.SUBTRACT, 0); }
		public AdditiveExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.EnterAdditiveExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.ExitAdditiveExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExcelCalculatorVisitor<TResult> typedVisitor = visitor as IExcelCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAdditiveExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NumberExprContext : ExpressionContext {
		public ITerminalNode NUMBER() { return GetToken(ExcelCalculatorParser.NUMBER, 0); }
		public NumberExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.EnterNumberExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.ExitNumberExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExcelCalculatorVisitor<TResult> typedVisitor = visitor as IExcelCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumberExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IdentifierExprContext : ExpressionContext {
		public ITerminalNode IDENTIFIER() { return GetToken(ExcelCalculatorParser.IDENTIFIER, 0); }
		public IdentifierExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.EnterIdentifierExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.ExitIdentifierExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExcelCalculatorVisitor<TResult> typedVisitor = visitor as IExcelCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifierExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenthesizedExprContext : ExpressionContext {
		public ITerminalNode LPAREN() { return GetToken(ExcelCalculatorParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(ExcelCalculatorParser.RPAREN, 0); }
		public ParenthesizedExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.EnterParenthesizedExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.ExitParenthesizedExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExcelCalculatorVisitor<TResult> typedVisitor = visitor as IExcelCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenthesizedExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LogicFunctionExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode AND() { return GetToken(ExcelCalculatorParser.AND, 0); }
		public ITerminalNode OR() { return GetToken(ExcelCalculatorParser.OR, 0); }
		public LogicFunctionExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.EnterLogicFunctionExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.ExitLogicFunctionExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExcelCalculatorVisitor<TResult> typedVisitor = visitor as IExcelCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLogicFunctionExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LogicFunctorExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode EQUALLITYDIGIT() { return GetToken(ExcelCalculatorParser.EQUALLITYDIGIT, 0); }
		public ITerminalNode MOREDIGIT() { return GetToken(ExcelCalculatorParser.MOREDIGIT, 0); }
		public ITerminalNode LESSDIGIT() { return GetToken(ExcelCalculatorParser.LESSDIGIT, 0); }
		public LogicFunctorExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.EnterLogicFunctorExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.ExitLogicFunctorExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExcelCalculatorVisitor<TResult> typedVisitor = visitor as IExcelCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLogicFunctorExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ArithmeticFunctionExprContext : ExpressionContext {
		public IToken operatorToken;
		public ITerminalNode LPAREN() { return GetToken(ExcelCalculatorParser.LPAREN, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(ExcelCalculatorParser.RPAREN, 0); }
		public ITerminalNode MOD() { return GetToken(ExcelCalculatorParser.MOD, 0); }
		public ITerminalNode DIV() { return GetToken(ExcelCalculatorParser.DIV, 0); }
		public ArithmeticFunctionExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.EnterArithmeticFunctionExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExcelCalculatorListener typedListener = listener as IExcelCalculatorListener;
			if (typedListener != null) typedListener.ExitArithmeticFunctionExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExcelCalculatorVisitor<TResult> typedVisitor = visitor as IExcelCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArithmeticFunctionExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 26;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case LPAREN:
				{
				_localctx = new ParenthesizedExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 8; Match(LPAREN);
				State = 9; expression(0);
				State = 10; Match(RPAREN);
				}
				break;
			case NOT:
				{
				_localctx = new NotFunctionExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 12; ((NotFunctionExprContext)_localctx).operatorToken = Match(NOT);
				State = 13; Match(LPAREN);
				State = 14; expression(0);
				State = 15; Match(RPAREN);
				}
				break;
			case MOD:
			case DIV:
				{
				_localctx = new ArithmeticFunctionExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 17;
				((ArithmeticFunctionExprContext)_localctx).operatorToken = _input.Lt(1);
				_la = _input.La(1);
				if ( !(_la==MOD || _la==DIV) ) {
					((ArithmeticFunctionExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 18; Match(LPAREN);
				State = 19; expression(0);
				State = 20; Match(T__0);
				State = 21; expression(0);
				State = 22; Match(RPAREN);
				}
				break;
			case NUMBER:
				{
				_localctx = new NumberExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 24; Match(NUMBER);
				}
				break;
			case IDENTIFIER:
				{
				_localctx = new IdentifierExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 25; Match(IDENTIFIER);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			_ctx.stop = _input.Lt(-1);
			State = 42;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 40;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
					case 1:
						{
						_localctx = new LogicFunctionExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 28;
						if (!(Precpred(_ctx, 7))) throw new FailedPredicateException(this, "Precpred(_ctx, 7)");
						State = 29;
						((LogicFunctionExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==AND || _la==OR) ) {
							((LogicFunctionExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 30; expression(8);
						}
						break;

					case 2:
						{
						_localctx = new LogicFunctorExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 31;
						if (!(Precpred(_ctx, 6))) throw new FailedPredicateException(this, "Precpred(_ctx, 6)");
						State = 32;
						((LogicFunctorExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << EQUALLITYDIGIT) | (1L << MOREDIGIT) | (1L << LESSDIGIT))) != 0)) ) {
							((LogicFunctorExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 33; expression(7);
						}
						break;

					case 3:
						{
						_localctx = new MultiplicativeExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 34;
						if (!(Precpred(_ctx, 4))) throw new FailedPredicateException(this, "Precpred(_ctx, 4)");
						State = 35;
						((MultiplicativeExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==MULTIPLY || _la==DIVIDE) ) {
							((MultiplicativeExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 36; expression(5);
						}
						break;

					case 4:
						{
						_localctx = new AdditiveExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 37;
						if (!(Precpred(_ctx, 3))) throw new FailedPredicateException(this, "Precpred(_ctx, 3)");
						State = 38;
						((AdditiveExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==ADD || _la==SUBTRACT) ) {
							((AdditiveExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 39; expression(4);
						}
						break;
					}
					} 
				}
				State = 44;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 7);

		case 1: return Precpred(_ctx, 6);

		case 2: return Precpred(_ctx, 4);

		case 3: return Precpred(_ctx, 3);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x15\x30\x4\x2\t"+
		"\x2\x4\x3\t\x3\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x5\x3\x1D\n\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\a\x3+\n\x3\f\x3\xE\x3.\v\x3\x3\x3\x2\x2\x3\x4"+
		"\x4\x2\x2\x4\x2\x2\a\x3\x2\r\xE\x3\x2\b\t\x3\x2\n\f\x3\x2\xF\x10\x3\x2"+
		"\x11\x12\x35\x2\x6\x3\x2\x2\x2\x4\x1C\x3\x2\x2\x2\x6\a\x5\x4\x3\x2\a\b"+
		"\a\x2\x2\x3\b\x3\x3\x2\x2\x2\t\n\b\x3\x1\x2\n\v\a\x13\x2\x2\v\f\x5\x4"+
		"\x3\x2\f\r\a\x14\x2\x2\r\x1D\x3\x2\x2\x2\xE\xF\a\a\x2\x2\xF\x10\a\x13"+
		"\x2\x2\x10\x11\x5\x4\x3\x2\x11\x12\a\x14\x2\x2\x12\x1D\x3\x2\x2\x2\x13"+
		"\x14\t\x2\x2\x2\x14\x15\a\x13\x2\x2\x15\x16\x5\x4\x3\x2\x16\x17\a\x3\x2"+
		"\x2\x17\x18\x5\x4\x3\x2\x18\x19\a\x14\x2\x2\x19\x1D\x3\x2\x2\x2\x1A\x1D"+
		"\a\x4\x2\x2\x1B\x1D\a\x6\x2\x2\x1C\t\x3\x2\x2\x2\x1C\xE\x3\x2\x2\x2\x1C"+
		"\x13\x3\x2\x2\x2\x1C\x1A\x3\x2\x2\x2\x1C\x1B\x3\x2\x2\x2\x1D,\x3\x2\x2"+
		"\x2\x1E\x1F\f\t\x2\x2\x1F \t\x3\x2\x2 +\x5\x4\x3\n!\"\f\b\x2\x2\"#\t\x4"+
		"\x2\x2#+\x5\x4\x3\t$%\f\x6\x2\x2%&\t\x5\x2\x2&+\x5\x4\x3\a\'(\f\x5\x2"+
		"\x2()\t\x6\x2\x2)+\x5\x4\x3\x6*\x1E\x3\x2\x2\x2*!\x3\x2\x2\x2*$\x3\x2"+
		"\x2\x2*\'\x3\x2\x2\x2+.\x3\x2\x2\x2,*\x3\x2\x2\x2,-\x3\x2\x2\x2-\x5\x3"+
		"\x2\x2\x2.,\x3\x2\x2\x2\x5\x1C*,";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace OOPFirstLab.ANTLR
