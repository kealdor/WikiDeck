﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiDeck
{
    public partial class FormChooseDeck : Form
    {
        private Decks _decks;

        public string ChosenDeck { get; private set; }

        public FormChooseDeck(Decks decks)
        {
            InitializeComponent();
            _decks = decks;
            listBoxDecks.DataSource = _decks;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ChosenDeck = (string)listBoxDecks.SelectedItem;
        }

        private void listBoxDecks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChosenDeck = (string)listBoxDecks.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listBoxDecks.DataSource = null;
            Application.DoEvents();
            _decks.Load("http://magicduels.wikia.com/");
            listBoxDecks.DataSource = _decks;
        }
    }
}
