using Java.Lang;

namespace MultiplicationTables;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void onSubmitClicked(object sender, EventArgs e)
	{
        //stores user input
		var userInput = entry.Text;
        var limit = upperLimitEntry.Text;

        //validates if the user input is empty or not
        if (userInput != null && userInput != "" && limit != null && limit != "")
        {   
            if (userInput.Contains(".") == false && limit.Contains(".") == false) {
                int upperLimit = Int32.Parse(limit);
                    multiplyData(upperLimit);
            }
            else
            {
                errorMsg.Text = "Please enter a whole number";
                errorMsg.IsVisible = true;

                resultMsg.IsVisible = false;
            }
        }
        else {
            //error message when the field is empty
            errorMsg.Text = "Text field cannot be empty";
            errorMsg.IsVisible = true;

            resultMsg.IsVisible = false;
        }

        SemanticScreenReader.Announce(multiply.Text);
	}

    //to multiply
    void multiplyData(int upperLimit) {
        //convert the user input from string to number
        int number = Int32.Parse(entry.Text);
        //hiding the error message
        errorMsg.IsVisible = false;
        //validate the user input falls inside the given range
        if (number <= 50 && number >= -50)
        {
            //variable to store result
            var result = "Result: \n";

            
            //for-loop for getting the multiplication upto number 12
            for (int i = 1; i <= upperLimit; i++)
            {
                var productValue = number * i;
                result += $"{number} x {i} = {productValue}\t\n";
            }
            //setting the result text
            resultMsg.Text = result;
            //display the result text
            resultMsg.IsVisible = true;
        }
        else
        {
            //show error message to the user
            errorMsg.Text = "Invalid number";
            errorMsg.IsVisible = true;
        }
    }
}


