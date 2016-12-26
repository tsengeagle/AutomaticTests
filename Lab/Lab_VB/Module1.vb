Imports Microsoft.VisualStudio.TestTools.UnitTesting
Module Module1

    Sub Main()

    End Sub

End Module

<TestClass()>
Public Class MyTest

    <TestMethod()>
    Public Sub MyTestMethod()

        Assert.AreEqual(1, 1)
    End Sub

End Class