<template>
  <div>
    <form @submit.prevent="create" action="/assets/inc/sendemail.php">
      <input v-model="createData.title" type="text" placeholder="Title" name="title">
      <input v-model="createData.description" type="text" placeholder="Description" name="description">
      <input v-model="createData.startDate" type="date" name="startDate">
      <input v-model="createData.endDate" type="date" name="endDate">
      <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
    </form><!-- /.become-teacher__form-content -->
  </div>

</template>

<script>
  import https from 'https';
  export default {
    name: 'EditCourse',
  }
</script>
