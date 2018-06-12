$(document).ready(function () {


    /********ATTRIBUTES**************************/
    $("#attributes p:nth-child(1)").click(function () {
        $("#resultAttr").addClass("classA").addClass("classB");
        $("#resultAttr").addClass(function (index) {
            console.log(index);
            return "classC";
        });
    });

    /*******************/
    $("#attributes p:nth-child(2)").click(function () {
        $("#resultAttr").attr("align", "center");
        var al = $(this).attr("align");
        $("#resultAttr").attr({
            align: "left"
        });
        console.log(al);
        $("#resultAttr").text(al);
    });
    /*****************************/
    $("#attributes p:nth-child(3)").click(function () {
        var hasclass = $("#resultAttr").hasClass("classA");

        $("#resultAttr").text("Has class A? : " + hasclass);

    });
    /*****************************/
    $("#attributes p:nth-child(4)").on(
        {
            mouseenter: function () {
                var ht = $("#resultAttr").html();

                console.log(ht);
                $("#resultAttr").text(ht);
            },
            mouseleave:function(){
                $("#resultAttr").text("html");
            }
        }
        );

    /*******************/
    $("#attributes p:nth-child(5)").click(function () {
        var t = $(":checkbox");
       
        var chck = $(":checkbox").prop("checked");
    
        $("#resultAttr").text(chck);
    });
    /*****************************/   
    $("#attributes p:nth-child(6)").on(
         {           
             click: function () {
                 $("p:nth-child(1)").removeClass("classA");
              
             } 
         }
     );    
    /*******************/
    $("#attributes p:nth-child(7)").click(function () {

        $("#resultAttr").toggleClass("classA");
    });
    /*******************/
    $("#attributes p:nth-child(8)").click(function () {

        $(":input").val("Added text by using .val");
    });





    /*****************************/ 
    //CALLBACKS
    /*****************************/ 
    var callbacks = $.Callbacks();
    var foo1 = function (value) {
        $("#result").text(" foo1 was called" + value);
    }
    var foo2 = function (value) {
        $("#result").text(" foo2 was called" + value);
    }
    $("#callbacks p:nth-child(1)").click(function () {

        callbacks.add(foo1);
        callbacks.add(foo2);
        $("#result").text("foo1 & foo2 added -use .has() to check this or   execute .fire()");

    })
    $("#callbacks p:nth-child(5)").click(function () {
        console.log(callbacks.disabled());
        if (callbacks.disabled())
        {
            $("#result").text(" Still Disabled - please clear and add once again");
        }
        callbacks.fire(" -Yupii !!!")
    })

    /**************Disable*******************/
    $("#callbacks p:nth-child(2)").click(function () {
        $("#result").text("Disabled (you shouldn't see the result!");
        callbacks.disable();
        callbacks.fire(" -Yupii !!!")

    })

    /**************Empty*******************/
    $("#callbacks p:nth-child(4)").click(function () {
        $("#result").text("Cleared - use .has() to check this");
        callbacks.empty();
        callbacks.fire(" -Yupii !!!")

    })

    /**************Empty*******************/
    $("#callbacks p:nth-child(8)").click(function () {
        console.log(callbacks.has());
        var eq = callbacks.has();

        $("#result").text("Callback" + (eq == true ? "Has registered functions" : "is empty"));
      
    })
    /**************Empty*******************/
    $("#callbacks p:nth-child(9)").click(function () {
    
        callbacks.lock();
        callbacks.add(function () {

            $("#result").text("WFT!");
        }
            );
        $("#result").text("callback is locked -> then registered new fct..try to fire all of them");

    })

    /**************locked*******************/
    $("#callbacks p:nth-child(10)").click(function () {


        $("#result").text("is locked: " + callbacks.locked());

    })
 


    $("#core p:nth-child(7)").click(function () {

        var d1 = $.Deferred();        
        (d1).done(function (v1) {
            $("#resultCore").text(v1);
        });
        d1.resolve(5);
    });


    $("#ajax p:nth-child(1)").click(function () {
        $.ajax(url = "/People/GetPeopleDataJson?selectedRole=User", options = {
            method: "GET",
            dataType: "json"

        }).done(function (data) {
            console.log(data);
        });
    });
        


});
