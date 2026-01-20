Imports System.Reflection.Emit
Imports System.Windows

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frequency = FrequencyIn.Text
        Dim wavelenght = WavelenghtIn.Text

        FrequencyIn.Text = (300 / (wavelenght))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frequency = FrequencyIn.Text
        Dim wavelenght = WavelenghtIn.Text

        WavelenghtIn.Text = (300000000 / (frequency * 1000000))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrequencyIn.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WavelenghtIn.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrequencyIn.Text = ""
        WavelenghtIn.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dbd = dbdIn.Text
        Dim dbi = dbiIn.Text

        dbiIn.Text = (dbd + 2.15)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim dbd = dbdIn.Text
        Dim dbi = dbiIn.Text

        dbdIn.Text = (dbi - 2.15)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        dbdIn.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        dbiIn.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        dbdIn.Text = ""
        dbiIn.Text = ""
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim heightm As Double

        heightm = Convert.ToDouble(metersh.Text)

        loskm.Text = Convert.ToString(Math.Sqrt(12.746 * heightm))


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        metersh.Text = ""
        feeth.Text = ""
        loskm.Text = ""
        losmi.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim heightft As Double

        heightft = Convert.ToDouble(feeth.Text)

        losmi.Text = Convert.ToString(Math.Sqrt(heightft) * 1.23)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim mc As Double

        mc = Convert.ToDouble(mcv.Text)

        ftcv.Text = Convert.ToString(mc * 0.3048)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim ftc As Double

        ftc = Convert.ToDouble(ftcv.Text)

        mcv.Text = Convert.ToString(ftc / 0.3048)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim kmc As Double

        kmc = Convert.ToDouble(kmcv.Text)

        micv.Text = Convert.ToString(kmc * 1.609)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim mic As Double

        mic = Convert.ToDouble(micv.Text)

        kmcv.Text = Convert.ToString(mic / 1.609)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim inputp As Double
        Dim antgn As Double
        Dim cablel As Double

        inputp = Convert.ToDouble(inputpwr.Text)
        antgn = Convert.ToDouble(antgain.Text)
        cablel = Convert.ToDouble(cableloss.Text)

        Dim eirpdw As Double = (10 * Math.Log10(inputp) + antgn - cablel + 30)
        Dim erpdw As Double = (10 * Math.Log10(inputp) + antgn - cablel - 2.15 + 30)
        Dim eirp As Double = (Math.Pow(10, ((eirpdw - 30) / 10)))
        Dim erp As Double = (Math.Pow(10, ((erpdw - 30) / 10)))


        erpw.Text = Convert.ToString(erp)
        erpdbm.Text = Convert.ToString(erpdw)
        eirpw.Text = Convert.ToString(eirp)
        eirpdbm.Text = Convert.ToString(eirpdw)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim wattscv As Double

        wattscv = Convert.ToDouble(wattss.Text)

        Dim dbwcvt As Double = (10 * Math.Log10(wattscv) + 30)


        dbms.Text = Convert.ToString(dbwcvt)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim dbmcv As Double

        dbmcv = Convert.ToDouble(dbms.Text)

        Dim wattscvt As Double = (Math.Pow(10, ((dbmcv - 30) / 10)))

        wattss.Text = Convert.ToString(wattscvt)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        wattss.Text = ""
        dbms.Text = ""
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        inputpwr.Text = ""
        antgain.Text = ""
        erpw.Text = ""
        erpdbm.Text = ""
        eirpw.Text = ""
        eirpdbm.Text = ""
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        pwrdbm.Text = ""
        fields.Text = ""
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim pdbm As Double
        Dim syz As Double

        pdbm = Convert.ToDouble(pwrdbm.Text)
        syz = Convert.ToDouble(sysz.Text)


        Dim fis As Double = (pdbm + 10 * Math.Log10(syz) + 90)

        fields.Text = Convert.ToString(fis)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim syz As Double
        Dim fis As Double

        fis = Convert.ToDouble(fields.Text)
        syz = Convert.ToDouble(sysz.Text)

        Dim pdbm As Double = (fis - 10 * Math.Log10(syz) - 90)

        pwrdbm.Text = Convert.ToString(pdbm)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim alphah As Double

        alphah = Convert.ToDouble(TextBox4.Text)

        Dim alpha As Double = (alphah / 100)

        TextBox3.Text = Convert.ToString(alpha)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim alpha As Double
        Dim met As Double

        alpha = Convert.ToDouble(TextBox3.Text)
        met = Convert.ToDouble(TextBox2.Text)

        Dim total As Double = (alpha * met)

        TextBox1.Text = Convert.ToString(total)

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim total As Double
        Dim met As Double

        total = Convert.ToDouble(TextBox1.Text)
        met = Convert.ToDouble(TextBox2.Text)

        Dim alpha As Double = (total / met)

        TextBox3.Text = Convert.ToString(alpha)
    End Sub
End Class