using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TextStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextStack undoStack = new TextStack();//For program.
        TextStack redoStack = new TextStack();//For program.
        TextStack undoStackTest = new TextStack();//For test data.
        TextStack redoStackTest = new TextStack();//For test data
        string currentSentence = " ";
        private void writeBtn_Click(object sender, EventArgs e)//Button code that takes the value from a TextBox to add a new word
        {
            if (textBox.Text != null && textBox.Text != " ")
            {
                string newUndo = textBox.Text.ToString();
                currentSentence += (newUndo);
                undoStack.Push(newUndo);
                redoStack=new TextStack();
                textArea.AppendText("Write Action:" + newUndo + Environment.NewLine + "Current Sentence:" + currentSentence + Environment.NewLine);
                alertLabel.Text = " ";

            }


        }

        private void undoBtn_Click(object sender, EventArgs e)//Button that performs the Undo operation.
        {
            if (undoStack.isEmpty() == false)
            {
                string undo = undoStack.Pop();
                currentSentence = currentSentence.Substring(0, currentSentence.Length - undo.Length);
                redoStack.Push(undo);
                textArea.AppendText("UNDO Action:" + undo + Environment.NewLine + "Current Sentences:" + currentSentence + Environment.NewLine); alertLabel.Text = " ";
            }
            else
            {
                alertLabel.Text = "There is no undo action.";
            }

        }


        private void redoBtn_Click(object sender, EventArgs e)//Button that performs the Redo operation.
        {
            if (redoStack.isEmpty() == false)
            {
                string redo = redoStack.Pop();
                currentSentence += redo;
                undoStack.Push(redo);
                textArea.AppendText("REDO Action:" + redo + Environment.NewLine + "Current Sentences:" + currentSentence + Environment.NewLine);
                alertLabel.Text = " ";

            }
            else
            {
                alertLabel.Text = "There is no redo action.";
            }


        }

        private void exampleBtn_Click(object sender, EventArgs e)//Button to display the requested example
        {
            currentSentence = " ";//To prevent errors
            CommandQ queue = new CommandQ(20);
            string[] tokens=exampleBox.Text.Split(' ');
            for(int i = 0; i < tokens.Length; i++)
            {
                queue.Enqueue(tokens[i]);
                
            }
            while (queue.isEmpty()==false)
            {
                string cmpValue=queue.Dequeue();
                if (cmpValue == "w")
                {
                    string value=queue.Dequeue();
                    undoStackTest.Push(value);
                    currentSentence += (" "+value);
                    richTextBox1.AppendText("Write Action:" + value + Environment.NewLine+"Current Sentence:"+currentSentence+Environment.NewLine);
                }
                else if(cmpValue == "u"){
                    if (undoStackTest.isEmpty() == false)
                    {
                        string undo = undoStackTest.Pop();
                        currentSentence = currentSentence.Substring(0, currentSentence.Length - undo.Length);
                        redoStackTest.Push(undo);
                        richTextBox1.AppendText("UNDO Action:"+undo+Environment.NewLine+ "Current Sentences:" + currentSentence + Environment.NewLine);
                    }
                }
                else if (cmpValue=="r"){
                    if (redoStackTest.isEmpty() == false)
                    {
                        string redo = redoStackTest.Pop();
                        currentSentence += redo;
                        undoStackTest.Push(redo);
                        richTextBox1.AppendText("REDO Action:"+redo+Environment.NewLine+"Current Sentences:"+currentSentence + Environment.NewLine);
                    }
                }
                else if (cmpValue == "s") 
                {
                    richTextBox1.AppendText("Result:"+currentSentence.Trim());
                    currentSentence = ""; //To prevent errors
                    break;
                }

            }
        }
    }
}
