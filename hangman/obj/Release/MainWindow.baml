   M S B A M L   `   `   `  ���� B  >hangman, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:hangmanhangman      hangman.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:hangman       � Title$  Hangman��$	��400��$��627.2�� � 
ResizeMode$ CanMinimize=�.��� -   $
��Grid�� � RowDefinitions �� $��244.8 ���  � ColumnDefinitions �� $��147.2 ��� .+��� -   $��StartButton��
�������$��
Constantia)�$��Start��$��20,64.2,0,0q�$��35��$	��Top=�$
��Left=�$	��100��$��1���� -    ��Name$ CharList��$��
Constantia)�$��15(�$
��Left=�$��22,10,0,9.8q�$��98���� -   $��GuessButton��
�������$��
Constantia)�$��Guess��$��
20,2.2,0,0q�$
��Left=�$	��Top=�$	��100��$��35��$��1���� -   $��HangAll��$
��Left=�$	��Top=�$��
22,-16,0,0q�$��0��$��0��.+��� -    ��Name$ 
HangGround��	 �� X1$ 0��	 �� Y1$ 0��	 �� X2$	 130��		 �� Y2$	 0��$
��Left=�$	��Top=�
���   �$��7��
 �� Left$	
 214��
 �� Top$	 223���� -   $ HangRope��$ 0��$ 0��$ 6��$	 28��$	
 265��$ 30��$��3�����	#FFA99494�� -    ��Name$ HangBar��.+��� -	   $ 	HangStand��$ 0��$ 0��$ 0��$		 200��$	
 216��$ 26��
���   �$��6���� -
   $ HangTop��$ -5��$ 0��$ 80��$	 0��$	
 219��$ 28��
���   �$��6���� -   $��HangHeadCan��.+�A� -   $��HangHead��$��38��$	
 261��
���   �$��2��$ 54��$��38���� -   $��HangBody��$ 0��$ 0��$ -6��$	 75��$	
 267��$ 86��
���   �$��2�� J� RenderTransformOrigin$ 0.5,0.5&��� -   $��	HangHands��.+��� -   $��	HangLHand��$ 0��$ 0��$ 24��$	 -7��$	
 242��$	 119��
���   �$��2��$ 0.5,0.5&��� -   $��	HangRHand��$ 0��$ 0��$ 10��$	 25��$	
 264��$	 111��
���   �$��2��$ 0.5,0.5&��� -   $��HangLegs��.+��� -   $��HangLLeg��$ 10��$ 20��$ 25��$		 -10��$	
 236��$	 169��
���   �$��2��$ 0.5,0.5&��� -   $��HangRLeg��$ 10��$	 -14��$ 15��$	 25��$	
 252��$	 173��
���   �$��2��$ 0.5,0.5&��� -   $��ShowWrongGuesses��$��15(�$�� ��$��319.8,182,0,0q�$��49��$
��Left=�$	��Top=�$��74��$��1���� $��15(�$��Lives left:��$��
Constantia)�$��254.8,182,0,0q�$
��Left=�$	��Top=�$��1��$��29��$��75���� $��1��$��14(�$��
Constantia)�$
��Left=�$��248.8,10,0,0q�$
��Wrap=�$��Wrong letters guessed:��$	��Top=�$��26��$	��145���� $��Guess the word:��$��14(�$��
Constantia)�$��1��$
��Left=�$��9.8,33.2,0,0q�$��1��$	��Top=��� -   $��TheWord��$��30(�$�� ��$��1��$
��Left=�$��115.8,12.2,0,0q�$��1��$	��Top=��� -   $��About��
��� ���$��About��$��1��$
��Left=�$��18��$��405.8,97.2,0,0q�$��1��$	��Top=�$��54��