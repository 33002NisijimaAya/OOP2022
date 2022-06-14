﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();
        int count = 0;

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            if (tbName.Text == "") {
                MessageBox.Show("名前を入力してください");
            }
            else {
                btDelete.Enabled = true;
                btUpdate.Enabled = true;
                Person newPerson = new Person {
                    Name = tbName.Text,
                    MailAddress = tbMailAddress.Text,
                    Address = tbAddress.Text,
                    Company = tbCompany.Text,
                    Picture = pbPicture.Image,
                    listGroup = GetCheckBoxGroup(),
                };
                count++;
                listPerson.Add(newPerson);
                dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;
            }
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if(cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }
            if(cbFriend.Checked){
                listGroup.Add(Person.GroupType.友人);
            }
            if(cbWork.Checked){
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }

            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {
            
            //例
            //データグリッドビューのインデックス０番の名前をテキストボックスに格納
            //tb.Name.Text = listPerson[0].Name

            //選択されているインデックスを取得する
            if (dgvPersons.CurrentRow == null) return;

            int index = dgvPersons.CurrentRow.Index;
            
            //インデックスが取得出来たら、リスト（listPerson）の該当するインデックスに
            //アクセスし、リストの各項目を各テキストボックスへ表示する
            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            tbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;

            groupCheckBoxAllclear();//グループチェックボックスを一旦初期化

            foreach (var group in listPerson[index].listGroup) {
                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                    break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbWork.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void groupCheckBoxAllclear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {
                listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
                listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
                listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
                listPerson[dgvPersons.CurrentRow.Index].Company = tbCompany.Text;
                listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;

                dgvPersons.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e) {
            btDelete.Enabled = false; 　//削除ボタンをマスク
            btUpdate.Enabled = false;   //更新ボタンをマスク
        }

        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);
            if (listPerson.Count() == 0) {
                btDelete.Enabled = false;
                btUpdate.Enabled = false;
            }
            
        }
    }
}