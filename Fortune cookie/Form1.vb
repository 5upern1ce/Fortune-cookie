Imports System.Media

Public Class Form1
    Dim fortunes As New List(Of String) From {
        "A beautiful, smart, and loving person will be coming into your life.",
        "A faithful friend is a strong defense.",
        "A fresh start will put you on your way.",
        "A friend asks only for your time, not your money.",
        "A friend is a present you give yourself.",
        "A golden egg of opportunity falls into your lap this month.",
        "A good time to finish up old tasks.",
        "A lifetime of happiness lies ahead of you.",
        "A new perspective will come with the new year.",
        "A person is never too old to learn.",
        "A pleasant surprise is waiting for you.",
        "A short stranger will soon enter your life with blessings to share.",
        "A small donation is call for. It’s the right thing to do.",
        "A smile is your personal welcome mat.",
        "A soft voice may be awfully persuasive.",
        "A truly rich life contains love and art in abundance.",
        "Accept something that you cannot change, and you will feel better.",
        "Adventure can be real happiness.",
        "Advice, when most needed, is least heeded.",
        "All the effort you are making will ultimately pay off.",
        "All the troubles you have will pass away very quickly.",
        "An important person will offer you support.",
        "An inch of time is an inch of gold.",
        "Any decision you have to make tomorrow is a good decision.",
        "At the touch of love, everyone becomes a poet.",
        "Be careful or you could fall for some tricks today.",
        "Beauty in its various forms appeals to you.",
        "Believe in yourself and others will too.",
        "Bide your time, for success is near.",
        "Carve your name on your heart and not on marble.",
        "Chance favors those in motion.",
        "Competence like yours is underrated.",
        "Conquer your fears or they will conquer you.",
        "Congratulations! You are on your way.",
        "Count your blessings by thinking of those whom you love.",
        "Courtesy is contagious.",
        "Determination is what you need now.",
        "Do not be intimidated by the eloquence of others.",
        "Do not let ambitions overshadow small success.",
        "Do not make extra work for yourself.",
        "Do not underestimate yourself. Human beings have unlimited potentials.",
        "Don’t be discouraged, because every wrong attempt discarded is another step forward.",
        "Don’t confuse recklessness with confidence.",
        "Don’t just think, act!",
        "Don’t let friends impose on you. Work calmly and silently.",
        "Don’t let the past and useless detail choke your existence.",
        "Each day, compel yourself to do something you would rather not do.",
        "Education is the ability to meet life’s situations.",
        "Embrace change. Don’t battle it.",
        "Emulate what you admire in your parents.",
        "Every flower blooms in its own sweet time.",
        "Every wise man started out by asking many questions.",
        "Everyday in your life is a special occasion.",
        "Failure is the chance to do better next time.",
        "Fear is just excitement in need of an attitude adjustment.",
        "Fearless courage is the foundation of victory.",
        "Feeding a cow with roses does not get extra appreciation.",
        "First think of what you want to do; then do what you have to do.",
        "Follow the middle path. Neither extreme will make you happy.",
        "For hate is never conquered by hate. Hate is conquered by love.",
        "For the things we have to learn before we can do them, we learn by doing them.",
        "Fortune favors the brave.",
        "Go for the gold today! You’ll be the champion of whatever.",
        "Go take a rest; you deserve it.",
        "Good news will be brought to you by mail.",
        "Good to begin well, better to end well.",
        "Happiness begins with facing life with a smile and a wink.",
        "Happiness will bring you good luck.",
        "Happy life is just in front of you.",
        "Hard words break no bones, fine words butter no parsnips.",
        "Have a beautiful day.",
        "He who knows he has enough is rich.",
        "Help! I’m being held prisoner in a fortune cookie factory.",
        "How you look depends on where you go.",
        "If a true sense of value is to be yours, it must come through service.",
        "If certainty were truth, we would never be wrong.",
        "If you continually give, you will continually have.",
        "If you look in the right places, you can find some good offerings.",
        "If you want the rainbow, you have to tolerate the rain.",
        "If your desires are not extravagant, they will be granted.",
        "In order to take, one must first give.",
        "In the end all things will be known.",
        "It is better to deal with problems before they arise.",
        "It is honorable to stand up for what is right, however unpopular it seems.",
        "It takes courage to admit fault.",
        "It’s better to be alone sometimes.",
        "It’s impossible to please everybody.",
        "Keep your eye out for someone special.",
        "Let the deeds speak.",
        "Listen not to vain words of empty tongue.",
        "Living with a commitment to excellence shall take you far.",
        "Long life is in store for you.",
        "Love is as necessary to human beings as food and shelter.",
        "Love lights up the world.",
        "Man is born to live and not prepared to live.",
        "Many will travel to hear you speak.",
        "Meditation with an old enemy is advised.",
        "Miles are covered one step at a time.",
        "Nature, time and patience are the three great physicians.",
        "Never fear! The end of something marks the start of something new.",
        "New ideas could be profitable.",
        "New people will bring you new realizations, especially about big issues.",
        "No one can walk backwards into the future.",
        "Nothing is impossible to a willing heart.",
        "Now is a good time to buy stock.",
        "Now is the time to try something new.",
        "Observe all men, but most of all yourself.",
        "One of the secrets of a happy life is continuous small treats.",
        "Others can help you now.",
        "Pennies from heaven find their way to your doorstep this year!",
        "People are naturally attracted to you.",
        "People find it difficult to resist your persuasive manner.",
        "Perhaps you’ve been focusing too much on yourself."}
    Dim n As Integer = fortunes.Count

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Dim player As New SoundPlayer()
        player.Stream = My.Resources.music
        player.Play()
    End Sub

    Private Sub fortunelbl_Click(sender As Object, e As EventArgs) Handles fortunelbl.Click

    End Sub

    Private Sub Fortunebtn_Click(sender As Object, e As EventArgs) Handles Fortunebtn.Click
        Dim rnd As New Random()

        Dim randomNumber As Integer = rnd.Next(0, n)

        fortunelbl.Text = fortunes(randomNumber)
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Application.Exit()
    End Sub
End Class
