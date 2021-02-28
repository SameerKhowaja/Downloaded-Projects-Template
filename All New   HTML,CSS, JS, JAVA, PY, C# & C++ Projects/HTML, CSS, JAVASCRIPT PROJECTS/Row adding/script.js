function addRow() {

  var template = document.querySelector('#rowTemplate'),
    tbl = document.querySelector('#myTable'),
    td_slNo = template.content.querySelectorAll("td")[0],
    tr_count = tbl.rows.length;

  td_slNo.textContent = tr_count;
  var clone = document.importNode(template.content, true);
  tbl.appendChild(clone);

}