import PySimpleGUI as sg
from controller.IController import IController as cs
from model.Farbe import Farbe

sg.theme("Default1")
header = sg.Column(
    [
        [
            sg.Text(text="Alice 'X' Little", key="-p1-"),
            sg.Text("0 Wins", key="-p1wins-"),
            sg.Text("<<", key="-arrow-"),
            sg.Text("Barbara 'O' Gordon", key="-p2-"),
            sg.Text("0 Wins", key="-p2wins-"),
        ]
    ],
    justification="c",
)
center = sg.Column(
    [
        [
            sg.Frame(
                "Spielfeld",
                [
                    [
                        sg.Button(
                            "0_0",
                            key=(0, 0),
                            size=(10, 5),
                            expand_y=True,
                            expand_x=True,
                        ),
                        sg.Button(
                            "0_1",
                            key=(0, 1),
                            size=(10, 5),
                            expand_y=True,
                            expand_x=True,
                        ),
                        sg.Button(
                            "0_2",
                            key=(0, 2),
                            size=(10, 5),
                            expand_y=True,
                            expand_x=True,
                        ),
                    ],
                    [
                        sg.Button(
                            "1_0",
                            key=(1, 0),
                            size=(10, 5),
                            expand_y=True,
                            expand_x=True,
                        ),
                        sg.Button(
                            "1_1",
                            key=(1, 1),
                            size=(10, 5),
                            expand_y=True,
                            expand_x=True,
                        ),
                        sg.Button(
                            "1_2",
                            key=(1, 2),
                            size=(10, 5),
                            expand_y=True,
                            expand_x=True,
                        ),
                    ],
                    [
                        sg.Button(
                            "2_0",
                            key=(2, 0),
                            size=(10, 5),
                            expand_y=True,
                            expand_x=True,
                        ),
                        sg.Button(
                            "2_1",
                            key=(2, 1),
                            size=(10, 5),
                            expand_y=True,
                            expand_x=True,
                        ),
                        sg.Button(
                            "2_2",
                            key=(2, 2),
                            size=(10, 5),
                            expand_y=True,
                            expand_x=True,
                        ),
                    ],
                ],
                expand_y=True,
                expand_x=True,
                key="-feld-",
            )
        ]
    ],
    expand_y=True,
    expand_x=True,
)

feeder = sg.Column(
    [
        [
            sg.Button("Neues Spiel", key="-newgame-"),
            sg.Text("Systemantwort:"),
            sg.Text("hallo :)", key="-sys-"),
        ]
    ],
    justification="l",
)

_layout = [[header], [center], [feeder]]


class gui(object):
    col_dict = { Farbe.Blue :  "Blue",
    Farbe.Green : "LightGreen",
    Farbe.Red : "LightRed",
    Farbe.Orange : "Organge",
    Farbe.Purple : "Purple",
    Farbe.Azure : "LightBlue"}
    
    def __init__(self, controller=None):
        self._window = sg.Window("TicTacPy", _layout, resizable=True, finalize=True)
        self._controller: cs.IController = controller

    def update_Button(
        self, row: int = 0, col: int = 0, farbe: Farbe = Farbe.Azure
    ) -> None:

        self._window[(row, col)].update(
            text=" ", button_color=("black", gui.col_dict[farbe]), disabled=True
        )
        self._window.refresh()

    def Game_won(self, wins: int = 0, SpielerID: int = -1, Name: str = "CC"):
        val = f"{wins} Wins"
        if SpielerID == 0:
            self._window["-p1wins-"].update(value=val)
        elif SpielerID == 1:
            self._window["-p2wins-"].update(value=val)
        self._set_Feld(True)

        self._window["-sys-"].update(value=f"{Name} hat gewonnen.")
        self._window.refresh()

    def _button_clicked(self, row: int = -1, col: int = -1) -> None:
        self._controller.Button_pressed(row, col)

    def _new_Game(self) -> None:
        self._controller.neuesSpiel()
        for row in range(3):
            for col in range(3):
                self._window[(row, col)].update(
                    text="", button_color=("black", "#f0f0f0"), disabled=False
                )
        self._window.refresh()
    
    def setArrow(self, spieler:int=-1, far:Farbe=None):
        if spieler==0:
            val = "<<"
        else:
            val = ">>"
        self._window["-arrow-"].update(value=val, background_color = gui.col_dict[far])

    def setSpieler(
        self,
        P1: str = "Alice",
        P2: str = "Cassandra",
        f1: Farbe = None,
        f2: Farbe = None
    ):
        self._window["-p1-"].update(value=P1, background_color = gui.col_dict[f1])
        self._window["-p2-"].update(value=P2, background_color = gui.col_dict[f2])

        self._window.refresh()

    def _set_Feld(self, block: bool = True):
        for r in range(3):
            for c in range(3):
                self._window[(r, c)].update(disabled=block)

    def start_up(self):
        while True:
            event, values = self._window.read()
            if event == sg.WIN_CLOSED or event == "Cancel":
                break
            if event == "-newgame-":
                self._new_Game()

            if isinstance(event, tuple) and len(event) == 2:
                self._button_clicked(event[0], event[1])

        self._window.close()
