/*
* MATLAB Compiler: 4.18.1 (R2013a)
* Date: Wed Apr 30 16:03:03 2014
* Arguments: "-B" "macro_default" "-W" "dotnet:picture,PictureTest,0.0,private" "-T"
* "link:lib" "-d" "E:\SRTP\code\picture\src" "-w" "enable:specified_file_mismatch" "-w"
* "enable:repeated_file" "-w" "enable:switch_ignored" "-w" "enable:missing_lib_sentinel"
* "-w" "enable:demo_license" "-v" "class{PictureTest:E:\SRTP\code\graphics.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace pictureNative
{

  /// <summary>
  /// The PictureTest class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// E:\SRTP\code\graphics.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class PictureTest : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static PictureTest()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "picture.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the PictureTest class.
    /// </summary>
    public PictureTest()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~PictureTest()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the graphics MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object graphics()
    {
      return mcr.EvaluateFunction("graphics", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the graphics MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object graphics(Object a)
    {
      return mcr.EvaluateFunction("graphics", a);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the graphics MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object graphics(Object a, Object b)
    {
      return mcr.EvaluateFunction("graphics", a, b);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the graphics MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <param name="c">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object graphics(Object a, Object b, Object c)
    {
      return mcr.EvaluateFunction("graphics", a, b, c);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the graphics MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] graphics(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "graphics", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the graphics MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] graphics(int numArgsOut, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "graphics", a);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the graphics MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] graphics(int numArgsOut, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "graphics", a, b);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the graphics MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <param name="c">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] graphics(int numArgsOut, Object a, Object b, Object c)
    {
      return mcr.EvaluateFunction(numArgsOut, "graphics", a, b, c);
    }


    /// <summary>
    /// Provides an interface for the graphics function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("graphics", 3, 1, 0)]
    protected void graphics(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("graphics", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
