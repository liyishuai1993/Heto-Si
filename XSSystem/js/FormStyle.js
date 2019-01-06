// 多选的全选与取消
function checkJs(boolvalue) {
    if (document.all.checkboxname.length > 1) {
        for (var i = 0; i < document.all.checkboxname.length; i++) {
            document.all.checkboxname[i].checked = boolvalue;
        }
    }
    else
        document.all.checkboxname.checked = boolvalue;
}
//

// 只有全部选中时“全选”选中
function SingleCheckJs() {
    var flag1 = false;
    var flag2 = false;

    if (document.form1.checkboxname.length) {
        for (var i = 0; i < document.form1.checkboxname.length; i++) {
            if (document.form1.checkboxname[i].checked)
                flag1 = true;
            else
                flag2 = true;
        }
    }
    else {
        if (document.form1.checkboxname.checked)
            flag1 = true;
        else
            flag2 = true;
    }

    if (flag1 == true && flag2 == false)
        document.getElementById("chk").checked = true;
    else
        document.getElementById("chk").checked = false;
}

function isnum() {
    if (((event.keyCode >= 48) && (event.keyCode <= 57)) || (event.keyCode == 46)) {
        event.returnValue = true;
    }
    else {
        event.returnValue = false;
    }
}

function clearNoNum(obj) {
    //先把非数字的都替换掉，除了数字和.

    obj.value = obj.value.replace(/[^\d.]/g, "");

    //保证只有出现一个.而没有多个.

 //   obj.value = obj.value.replace(/\.{2,}/g, ".");

    //必须保证第一个为数字而不是.

   // obj.value = obj.value.replace(/^\./g, "");

    //保证.只出现一次，而不能出现两次以上

   // obj.value = obj.value.replace(".", "$#$").replace(/\./g, "").replace("$#$", ".");

//只能输入两个小数
}

