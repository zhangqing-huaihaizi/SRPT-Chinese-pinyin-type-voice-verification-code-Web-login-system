/*
* MATLAB Compiler: 4.18.1 (R2013a)
* Date: Mon May 05 19:57:49 2014
* Arguments: "-B" "macro_default" "-W" "dotnet:sounding,SoundTest,0.0,private" "-T"
* "link:lib" "-d" "E:\SRTP\code\sounding\src" "-w" "enable:specified_file_mismatch" "-w"
* "enable:repeated_file" "-w" "enable:switch_ignored" "-w" "enable:missing_lib_sentinel"
* "-w" "enable:demo_license" "-v" "class{SoundTest:E:\SRTP\mix.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace soundingNative
{

  /// <summary>
  /// The SoundTest class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// E:\SRTP\mix.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class SoundTest : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static SoundTest()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "sounding.ctf";

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
    /// Constructs a new instance of the SoundTest class.
    /// </summary>
    public SoundTest()
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
    ~SoundTest()
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
    /// Provides a single output, 0-input Objectinterface to the mix MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s=randsrc(1,1,[11,12,13,14,15,16,17,18,19,20,21]);
    /// sui ji zao sheng
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mix()
    {
      return mcr.EvaluateFunction("mix", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the mix MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s=randsrc(1,1,[11,12,13,14,15,16,17,18,19,20,21]);
    /// sui ji zao sheng
    /// </remarks>
    /// <param name="s1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mix(Object s1)
    {
      return mcr.EvaluateFunction("mix", s1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the mix MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s=randsrc(1,1,[11,12,13,14,15,16,17,18,19,20,21]);
    /// sui ji zao sheng
    /// </remarks>
    /// <param name="s1">Input argument #1</param>
    /// <param name="s2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mix(Object s1, Object s2)
    {
      return mcr.EvaluateFunction("mix", s1, s2);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the mix MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s=randsrc(1,1,[11,12,13,14,15,16,17,18,19,20,21]);
    /// sui ji zao sheng
    /// </remarks>
    /// <param name="s1">Input argument #1</param>
    /// <param name="s2">Input argument #2</param>
    /// <param name="s3">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object mix(Object s1, Object s2, Object s3)
    {
      return mcr.EvaluateFunction("mix", s1, s2, s3);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the mix MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s=randsrc(1,1,[11,12,13,14,15,16,17,18,19,20,21]);
    /// sui ji zao sheng
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mix(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "mix", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the mix MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s=randsrc(1,1,[11,12,13,14,15,16,17,18,19,20,21]);
    /// sui ji zao sheng
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mix(int numArgsOut, Object s1)
    {
      return mcr.EvaluateFunction(numArgsOut, "mix", s1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the mix MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s=randsrc(1,1,[11,12,13,14,15,16,17,18,19,20,21]);
    /// sui ji zao sheng
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s1">Input argument #1</param>
    /// <param name="s2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mix(int numArgsOut, Object s1, Object s2)
    {
      return mcr.EvaluateFunction(numArgsOut, "mix", s1, s2);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the mix MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// s=randsrc(1,1,[11,12,13,14,15,16,17,18,19,20,21]);
    /// sui ji zao sheng
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="s1">Input argument #1</param>
    /// <param name="s2">Input argument #2</param>
    /// <param name="s3">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] mix(int numArgsOut, Object s1, Object s2, Object s3)
    {
      return mcr.EvaluateFunction(numArgsOut, "mix", s1, s2, s3);
    }


    /// <summary>
    /// Provides an interface for the mix function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// s=randsrc(1,1,[11,12,13,14,15,16,17,18,19,20,21]);
    /// sui ji zao sheng
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("mix", 3, 1, 0)]
    protected void mix(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("mix", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
