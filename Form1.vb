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
        losnmi.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim heightft As Double

        heightft = Convert.ToDouble(feeth.Text)

        losnmi.Text = Convert.ToString(Math.Sqrt(heightft) * 1.23)
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

        nmicv.Text = Convert.ToString(kmc * 1.852)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim nmic As Double

        nmic = Convert.ToDouble(nmicv.Text)

        kmcv.Text = Convert.ToString(nmic / 1.852)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim inputp As Double
        Dim antgn As Double

        inputp = Convert.ToDouble(inputpwr.Text)
        antgn = Convert.ToDouble(antgain.Text)

        Dim erp As Double = (inputp * Math.Pow(10, (antgn / 10)) - 2.15)
        Dim eirp As Double = (erp + 2.15)
        Dim erpdw As Double = (10 * Math.Log10(erp))
        Dim eirpdw As Double = (10 * Math.Log10(eirp))

        erpw.Text = Convert.ToString(erp)
        erpdbw.Text = Convert.ToString(erpdw)
        eirpw.Text = Convert.ToString(eirp)
        eirpdbw.Text = Convert.ToString(eirpdw)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim wattscv As Double

        wattscv = Convert.ToDouble(wattss.Text)

        Dim dbwcvt As Double = (10 * Math.Log10(wattscv))


        dbws.Text = Convert.ToString(dbwcvt)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim dbwcv As Double

        dbwcv = Convert.ToDouble(dbws.Text)

        Dim wattscvt As Double = (Math.Pow(10, (dbwcv / 10)))

        wattss.Text = Convert.ToString(wattscvt)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        wattss.Text = ""
        dbws.Text = ""
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        inputpwr.Text = ""
        antgain.Text = ""
        erpw.Text = ""
        erpdbw.Text = ""
        eirpw.Text = ""
        eirpdbw.Text = ""
    End Sub
End Class
