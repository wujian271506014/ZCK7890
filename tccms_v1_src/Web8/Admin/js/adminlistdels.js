
function quanxuan()
{
    $(".np").attr("checked",true);
}
function fanxuan()
{
    $.each($(".np"),function(i,n)
    {
        n.checked=!n.checked;
    });
}
